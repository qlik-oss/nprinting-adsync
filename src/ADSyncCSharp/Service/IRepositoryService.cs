using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSyncCSharp.Service
{
    /**
     * Handle the Active Directory highestCommittedUSN for following incremental sync
     */
    public interface IRepositoryService
    {
        long GetHighestCommittedUsn();

        void SaveHighestCommittedUsn(long highestCommittedUsn);
    }
}
