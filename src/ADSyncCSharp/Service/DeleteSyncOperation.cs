using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using ADSyncCSharp.Model;
using ADSyncCSharp.Processor;

namespace ADSyncCSharp.Service
{
    public class DeleteSyncOperation : SyncOperation<UserGroup>
    {
        private readonly IAdSyncConfig _ldapConfig;

        protected internal DeleteSyncOperation(IAdSyncConfig ldapConfig)
        {
            _ldapConfig = ldapConfig;
        }

        public void execute(string querySearchFilter, IEntryProcessor<UserGroup> entryProcessor)
        {
                string connectionString = "LDAP://" + _ldapConfig.GetUrl() + "/" + "CN=Deleted Objects," + _ldapConfig.GetSyncBaseDn();
            using (
                DirectoryEntry root =
                    new DirectoryEntry(connectionString,
                        _ldapConfig.GetBindUser(),
                        _ldapConfig.GetBindPassword())
                    {
                        AuthenticationType = AuthenticationTypes.FastBind | AuthenticationTypes.Secure
                    }
                 )
            using (
                DirectorySearcher search = new DirectorySearcher(root, string.Format(querySearchFilter, _ldapConfig.GetRootDn()))
                {
                    Tombstone = true,
                    SearchScope = SearchScope.Subtree
                }
            )
            using (SearchResultCollection results = search.FindAll())
            {
                IList<UserGroup> userGroups = new List<UserGroup>();
                foreach (SearchResult sr in results)
                {
                    var group = new UserGroup(sr.Properties["samaccountname"][0].ToString());
                    group.Role = new Role(group.Name.Split('_').Last());
                    userGroups.Add(group);
                }
                entryProcessor.ProcessDeleted(userGroups);
            }
        }
    }
}
