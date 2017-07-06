using System.Collections.Specialized;
using ADSyncCSharp.Model;


namespace ADSyncDemoApp.Component
{
    /**
     * Load Active Directory and NPrinting configuration parameters
     */
    public class AdSyncConfig : IAdSyncConfig
    {
        //Active Directory config vars
        private string _url;
        private string _bindUser;
        private string _bindPassword;
        private string _syncBaseDn;
        private string _searchFilter;
        private string _searchDeletedObjectsFilter;
        private string _rootDn;
        private string _domainName;

        //NPrinting configuration vars
        private string _npUrl;


    public static AdSyncConfig FromConfig(NameValueCollection configValues, Options options)
    {
        AdSyncConfig result = new AdSyncConfig()
        {
            //Active Directory Configuration
            _url = configValues.Get("url"),
            _domainName = configValues.Get("domainName"),
            _bindUser = options.BindUser,
            _bindPassword = options.BindPassword,
            _rootDn = configValues.Get("rootDN"),
            _syncBaseDn = configValues.Get("syncBaseDN"),
            _searchFilter = configValues.Get("searchFilter"),
            _searchDeletedObjectsFilter = configValues.Get("searchDeletedObjectsFilter"),

            //NPrinting Configuration
            _npUrl = configValues.Get("npUrl")
        };

            return result;
        }

        public string GetUrl()
        {
            return _url;
        }

        public string GetDomainName()
        {
            return _domainName;
        }

        public string GetBindUser()
        {
            return _bindUser;
        }

        public string GetBindPassword()
        {
            return _bindPassword;
        }

        public string GetRootDn()
        {
           return _rootDn;
        }

        public string GetSyncBaseDn()
        {
            return _syncBaseDn;
        }

        public string GetSearchFilter()
        {
           return _searchFilter;
        }

        public string GetSearchDeletedObjectsFilter()
        {
            return _searchDeletedObjectsFilter;
        }

        public string GetNpUrl()
        {
            return _npUrl;
        }
    }
}
