namespace efCorePracties.Controllers.Models
{
    public class PersonDTO
    {
        public PersonDTO()
        {

        }
        public int Id { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Address { get; set; }
        public virtual string Associate { get; set; }
        public virtual string Grade { get; set; }
        
    }
}