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
    }
}