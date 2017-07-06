

namespace ADSyncCSharp.Model
{
    /**
    * Interface for retrieving all the information required to maintain a synchronization relationship with a domain
    * controller. It's basically a recipe by which synchronization operations work.
    * <p/>
    * It defines properties:
    * <ul>
    * <li>on how to access and identify the domain controller and NPrinting,</li>
    * </ul>
    */
    public interface IAdSyncConfig
    {
        /**
        * @return The URL of the domain controller.
        */
        string GetUrl();

        /**
        * @return the Domain Name.
        */
        string GetDomainName();

        /**
         * @return The user name to authenticate with.
         */
        string GetBindUser();

        /**
         * @return The password to use on authentication.
         */
        string GetBindPassword();

        /**
         * @return DN of the root entry of the Active Directory tree (e.g. {@code DC=example,DC=com}).
         */
        string GetRootDn();

        /**
         * @return Return the base domain controller (e.g. {@code DC=example,DC=com}).
         */
        string GetSyncBaseDn();

        /**
         * @return LDAP filter expression that determines which entries should be retrieved during synchronization.
         */
        string GetSearchFilter();

        /**
         * @return LDAP filter expression to use when searching for deleted entries during an incremental synchronization.
         */
        string GetSearchDeletedObjectsFilter();

        /**
         * @return The URL of NPrinting.
         */
        string GetNpUrl();
    }
}
