using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using ADSyncCSharp.Model;
using ADSyncCSharp.Processor;
using ADSyncCSharp.Service;

namespace ADSyncDemoApp.Component
{
    /**
     * Handle an Incremental or a Full synch
     */
    class AdSync
    {
        private readonly IActiveDirectorySyncService _syncService;
        private readonly IRepositoryService _repoService;

        public AdSync(IRepositoryService repoService , ActiveDirectorySyncService syncService)
        {
            _repoService = repoService;
            _syncService = syncService;
        }

        /**
         * Run the synchronization process. If a local tHighestCommittedUsn is found then it performs an Incremental sync, Full sync otherwise. 
         */
        public void Sync()
        {
            //Add logic to incremental sync
            long localhighestCommittedUsn = _repoService.GetHighestCommittedUsn();
            if (localhighestCommittedUsn != -1)
            {
                //Perform incremental sync
                Console.WriteLine("Performing an incremental sync.");
                long newhighestCommittedUsn = _syncService.IncrementalSync(localhighestCommittedUsn);
                _repoService.SaveHighestCommittedUsn(newhighestCommittedUsn);
                Console.WriteLine("Incremental sync successfully done.");
            }
            else {
                //Perform full synch 
                Console.WriteLine("Performing a full sync.");
                long newhighestCommittedUsn = _syncService.FullSync();
                _repoService.SaveHighestCommittedUsn(newhighestCommittedUsn);
                Console.WriteLine("Full sync successfully done.");
            }
        }
    }
}
