using IdentityMultiProjScaf.Models.Models.Entities.Base;

namespace IdentityMultiProjScaf.Models.Models.Entities
{
    public class Person : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
