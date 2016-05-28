using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CISH6510.AddressBook.Models.Configuration
{
    public partial class ContactConfiguration : IEntityConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> entity)
        {
            entity.Property(e => e.FirstName)
				.IsRequired()
				.HasMaxLength(50);
			
			entity.Property(e => e.LastName)
				.IsRequired()
				.HasMaxLength(50);
			
			entity.Property(e => e.MiddleName)
				.HasMaxLength(50);
			
			entity.Property(e => e.Suffix)
				.HasMaxLength(50);
        }
    }
}