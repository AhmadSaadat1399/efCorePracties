using Microsoft.EntityFrameworkCore;
using efCorePracties.Models;
using efCorePracties.Controllers.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace efCorePracties.Models.Validation
{
    public class PersonDTOValidation : IEntityTypeConfiguration<PersonDTO>
    {

        public void Configure(EntityTypeBuilder<PersonDTO> builder)
        {
            builder
            .Property(b => b.FirstName).IsRequired();
            builder
            .Property(b => b.LastName).IsRequired();
            builder
            .Property(b=> b.Address);
            builder
            .Property(b=> b.Associate);
            builder
            .Property(b=> b.Grade);
         
        }
    }
}