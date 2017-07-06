using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSyncCSharp.Processor
{
 /**
 * A call-back interface through which clients of ADSyncToNPrinting can obtain the new/changed/deleted LDAP entries during
 * synchronization.
 * <p/>
 * In case of a full synchronization, all entries are reported as new.
 *
 */
    public interface IEntryProcessor<T>
    {

        /**
         * Call-back method invoked during a full or incremental synchronization.
         *
         * @param list of new entries. Define the logic for processing new entries in Active Directory
         */
        void ProcessNew(IList<T> entry);

        /**
         * Call-back method invoked during an incremental synchronization.
         *
         * @param list of changed entries. Define the logic for processing changed entries in Active Directory
         */
        void ProcessChanged(IList<T> entry);

        /**
         * Call-back method invoked during an incremental synchronization.
         *
         * @param list of deleted entries. Define the logic for processing deleted entries in Active Directory
         */
        void ProcessDeleted(IList<T> entry);
    }
}
