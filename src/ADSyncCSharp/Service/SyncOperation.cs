using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADSyncCSharp.Processor;

namespace ADSyncCSharp.Service
{
    /**
    * Internal interface with two implementations encapsulating the logic of the full and incremental synchronization
   * operations. Not to be directly used by clients.
   *
   * @param <LDAP_ATTRIBUTE>
   */
    public interface SyncOperation<T>
    {
        void execute(string querySearchFilter, IEntryProcessor<T> entryProcessor);
    }
}
