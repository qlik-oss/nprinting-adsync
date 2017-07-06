using System.Collections.Generic;

namespace ADSyncCSharp.Model
{
    /**
     * Represent a Group in Active Directory.
     */
    public class UserGroup
    {

        public UserGroup(string name)
        {
            Name = name;
            Users = new List<User>();
        }

        //Name of the Group
        public string Name { get; set; }
        
        //Description of the Group
        public string Description { get; set; }

        //Users of the Group
        public IList<User> Users { get; set; }

        //Role to assig to all the memeber of the Group
        public Role Role { get; set; }
    }
}
