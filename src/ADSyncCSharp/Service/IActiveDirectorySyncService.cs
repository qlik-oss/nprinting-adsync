
namespace ADSyncCSharp.Service
{   
    public interface IActiveDirectorySyncService
    {

        /**
         * Performs a full synchronization that retrieves all entries currently found in the synchronization scope in Active
         * Directory. Entries are delivered one-by-one to the caller by iteratively invoking {@link EntryProcessor#processNew
         * processNew()} on the provided {@link EntryProcessor}.
         *
         * @return The current highest committed Update Sequence Number on the server side that represents the point of time from
         *         which the next incremental synchronization will have to retrieve changes from Active Directory.
         */
        long FullSync();

        /**
         * Performs an incremental synchronization that only retrieves the entries created/changed/deleted after the point of time
         * represented by the highest committed Update Sequence Number that has been recorded by the last synchronization. Entries
         * are delivered one-by-one to the caller by iteratively invoking the corresponding methods of the provided
         * {@link EntryProcessor}.
         *
         * @param localHighestCommittedUsn Thr previous saved highest committed Update Sequence Number used to identified if an incremental synch is required.
         * @return The current highest committed Update Sequence Number on the server side that represents the point of time from
         *         which the next incremental synchronization will have to retrieve changes from Active Directory.
         */
        long IncrementalSync(long localHighestCommittedUsn);
    }
}
