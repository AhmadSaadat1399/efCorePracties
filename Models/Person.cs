using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace efCorePracties.Controllers.Models
{
    public class Person
    {
        
        public Person()
        {
            
        }
        [Key]
        public int Id { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string  Addres { get; set; }
        public virtual string Associate { get; set; }
        public virtual string Grade { get; set; }
    }
}