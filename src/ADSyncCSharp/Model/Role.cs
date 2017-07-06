
namespace ADSyncCSharp.Model
{
    /**
     * Define a Role in Active Directory
     */
    public class Role
    {
        public Role(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
