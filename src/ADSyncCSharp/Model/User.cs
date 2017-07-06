
namespace ADSyncCSharp.Model
{
    /**
     * User Details in Active Directory 
     */
    public class User
    {

        public User(string username)
        {
            Username = username;
        }

        public string Email { get; set; }
        public string Username { get; set; }
        public string Domainaccount { get; set; }
    }
}
