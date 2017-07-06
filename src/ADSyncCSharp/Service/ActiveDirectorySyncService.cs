using System.DirectoryServices.ActiveDirectory;
using System.Text;
using ADSyncCSharp.Model;
using ADSyncCSharp.Processor;

namespace ADSyncCSharp.Service
{
    public class ActiveDirectorySyncService : IActiveDirectorySyncService
    {
        private readonly IAdSyncConfig _ldapConfig;

        private readonly IEntryProcessor<UserGroup> _entryProcessor;

        public ActiveDirectorySyncService(IAdSyncConfig ldapConfig , IEntryProcessor<UserGroup> entryProcessor)
        {
            _ldapConfig = ldapConfig;
            _entryProcessor = entryProcessor;
        }

     /**
     * Combines the provided LDAP filter expression with an upper limit on the {@link ActiveDirectoryAttribute#USN_CHANGED
     * USN_CHANGED} attribute.
     * <p/>
     * Called when compiling the filter for a full synchronization.
     *
     * @param filter        The LDAP filter expression to complete.
     * @param upperBoundUSN Value for the upper limit of the {@link ActiveDirectoryAttribute#USN_CHANGED USN_CHANGED} attribute.
     * @return The provided LDAP filter combined with an upper bound on the {@link ActiveDirectoryAttribute#USN_CHANGED
     *         USN_CHANGED} attribute.
     */
        protected string GetFilterWithUpperBoundUsn(string filter, long upperBoundUsn)
        {
            string usnUpperBoundFilter = "uSNChanged" + "<=" + upperBoundUsn;
            return And(filter, usnUpperBoundFilter);
        }

        /**
        * Combines the provided LDAP filter expression with a lower and upper limit of the Active Directory sequence number
        * <p/>
        * Called when compiling the filter for an incremental synchronization.
        *
        * @param filter        The LDAP filter expression to complete.
        * @param upperBoundUSN Value for the sequence number upper limit.
        * @param lowerBoundUSN Value for the sequence number lower limit.
        * @return The provided LDAP filter combined with lower and upper bounds.
        */
        protected string GetFilterWithLowerAndUpperBoundUsn(string filter, long lowerBoundUsn, long upperBoundUsn)
        {
            string lowerBoundUsnFilter = "uSNChanged" + ">=" + lowerBoundUsn;
            string upperBoundUsnFilter = "uSNChanged" + "<=" + upperBoundUsn;
            return And(filter, upperBoundUsnFilter, lowerBoundUsnFilter);
        }


     /**
     * Combines the provided LDAP filter expressions into one single expression using the logical AND operator.
     *
     * @return A new LDAP filter expression that combines all input filters with the logical AND operator.
     */
        protected string And(string filters,  string upperBoundUsnFilter , string lowerBoundUsnFilter = null)
        {
            StringBuilder result = new StringBuilder("(&");
            result.Append(EnsureWrappedInParenthesis(filters));
            if (!string.IsNullOrWhiteSpace(lowerBoundUsnFilter))
            {
                result.Append(EnsureWrappedInParenthesis(lowerBoundUsnFilter));
            }
            result.Append(EnsureWrappedInParenthesis(upperBoundUsnFilter));
            result.Append(")");
            return result.ToString();
        }

        /**
         * Wraps the provided filter expression in parenthesis, unless it's already wrapped.
         *
         * @param filter An LDAP filter expression.
         * @return A {@link StringBuilder} containing the input filter wrapped in parenthesis if it was not wrapped before,
         *         otherwise the original filter expression is returned.
         */
        protected StringBuilder EnsureWrappedInParenthesis(string filter)
        {
            StringBuilder result = new StringBuilder(filter.Length + 2);
            if (filter.StartsWith("("))
            {
                return result.Append(filter);
            }
            else
            {
                return result
                        .Append("(")
                        .Append(filter)
                        .Append(")");
            }
        }

        /**
        * Retrieves the current highest Update Sequence Number that has been committed up to this point in the database of Active
        * Directory.
        *
        * @return The current highest committed Update Sequence Number.
        */
        protected long RetrieveRemoteHighestCommittedUsn()
        {
            DirectoryContext context = new DirectoryContext(DirectoryContextType.DirectoryServer, _ldapConfig.GetUrl(),
                _ldapConfig.GetBindUser(), _ldapConfig.GetBindPassword());
            using (DomainController domainController = DomainController.GetDomainController(context))
                return domainController.HighestCommittedUsn;
        }

        /**
         * Perform a Full synch 
         */
        public virtual long FullSync()
        {
            var remoteHighestCommittedUsn = RetrieveRemoteHighestCommittedUsn();
            string filterQueryWithUsn = GetFilterWithUpperBoundUsn(_ldapConfig.GetSearchFilter(), remoteHighestCommittedUsn);
            SyncOperation<UserGroup> doFullSync = new FullSyncOperation(_ldapConfig);
            doFullSync.execute(filterQueryWithUsn, _entryProcessor);
            return remoteHighestCommittedUsn;
        }

        /**
         * Perform an incremental synch 
         */
        public virtual long IncrementalSync(long localHighestCommittedUsn)
        {
            long remoteHighestCommittedUsn = RetrieveRemoteHighestCommittedUsn();
            //Perform an Incremental Sync only when there are changes
            if (remoteHighestCommittedUsn != localHighestCommittedUsn) { 
                string filterQueryWithUsn = GetFilterWithLowerAndUpperBoundUsn(_ldapConfig.GetSearchFilter(), localHighestCommittedUsn, remoteHighestCommittedUsn);
                SyncOperation<UserGroup> doIncrementalSync = new IncrementalSyncOperation(_ldapConfig);
                doIncrementalSync.execute(filterQueryWithUsn, _entryProcessor);
                string deleteQueryWithUsn = GetFilterWithLowerAndUpperBoundUsn(_ldapConfig.GetSearchDeletedObjectsFilter(), localHighestCommittedUsn, remoteHighestCommittedUsn);
                SyncOperation<UserGroup> doDeleteSync = new DeleteSyncOperation(_ldapConfig);
                doDeleteSync.execute(deleteQueryWithUsn, _entryProcessor);
            }
            return remoteHighestCommittedUsn;
        }
    }
}
