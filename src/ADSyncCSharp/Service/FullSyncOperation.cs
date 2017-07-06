using System;
using System.Collections;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADSyncCSharp.Model;
using ADSyncCSharp.Processor;
using System.DirectoryServices.AccountManagement;

namespace ADSyncCSharp.Service
{
    /**
     * Execute a Full sync running the query configured
     */
    class FullSyncOperation : SyncOperation<UserGroup>
    {
        private readonly IAdSyncConfig _ldapConfig;

        protected internal FullSyncOperation(IAdSyncConfig ldapConfig)
        {
            _ldapConfig = ldapConfig;
        }

        public void execute(string querySearchFilter, IEntryProcessor<UserGroup> entryProcessor)
        {
                using (
                    DirectoryEntry root =
                        new DirectoryEntry("LDAP://" + _ldapConfig.GetUrl() + "/" + _ldapConfig.GetRootDn(),
                            _ldapConfig.GetBindUser(),
                            _ldapConfig.GetBindPassword()))
                using (var ctx = new PrincipalContext(ContextType.Domain, _ldapConfig.GetUrl(),
                        _ldapConfig.GetBindUser(),
                        _ldapConfig.GetBindPassword()))
                using (
                    DirectorySearcher search = new DirectorySearcher(root, querySearchFilter, new string[] {"samaccountname", "description"}))
                using (SearchResultCollection results = search.FindAll())
                {
                    IList<UserGroup> userGroups = new List<UserGroup>();
                    foreach (SearchResult sr in results)
                    {
                        var group = new UserGroup(sr.Properties["samaccountname"][0].ToString());
                        Console.WriteLine("Processing Group: " + group.Name);
                        ResultPropertyValueCollection description = sr.Properties["description"];
                        if (description.Count > 0 )
                        {
                            group.Description = description[0].ToString();
                        }
                        group.Role = new Role(group.Name.Split('_').Last());
                        AddUsersToGroups(ctx, group);
                        userGroups.Add(group);
                    }
                    entryProcessor.ProcessNew(userGroups);
                }
        }


        private void AddUsersToGroups(PrincipalContext ctx, UserGroup group)
        {
            var groupPrincipal = GroupPrincipal.FindByIdentity(ctx, group.Name);
            if (groupPrincipal == null) return;
            using (var gp = groupPrincipal.GetMembers())
                foreach (UserPrincipal userPrincipal in gp)
                {
                    var user = new User(userPrincipal.SamAccountName)
                    {
                        Email = userPrincipal.EmailAddress,
                        Domainaccount = _ldapConfig.GetDomainName() + "\\" + userPrincipal.SamAccountName
                    };
                    group.Users.Add(user);
                }
        }
    }
}
