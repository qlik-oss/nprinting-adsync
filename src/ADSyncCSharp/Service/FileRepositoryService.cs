using System.IO;

namespace ADSyncCSharp.Service
{
    public class FileRepositoryService : IRepositoryService
    {
        private readonly string _filePath;

        public FileRepositoryService(string filePath)
        {
            _filePath = filePath;
        }

        /**
         * returen the HighestCommittedUsn previously saved. Needed for Incremental sync 
         */
        public virtual long GetHighestCommittedUsn()
        {
            string highestCommittedUsn = string.Empty;
            if (File.Exists(_filePath))
            {
                highestCommittedUsn = File.ReadAllText(_filePath);
            }

            if (string.IsNullOrWhiteSpace(highestCommittedUsn))
            {
                return -1;
            }

            long result;
            long.TryParse(highestCommittedUsn, out result);
            return result;
        }

        /**
         * Store the highestCommittedUsn
         */
        public virtual void SaveHighestCommittedUsn(long highestCommittedUsn)
        {
            File.WriteAllText(@_filePath, highestCommittedUsn.ToString());
        }
    }
}
