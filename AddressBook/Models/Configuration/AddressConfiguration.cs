using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CISH6510.AddressBook.Models.Configuration
{
    public partial class AddressConfiguration : IEntityConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> entity)
        {
            entity.Property(e => e.City)
				.IsRequired()
				.HasMaxLength(50);
			
			entity.Property(e => e.CompanyName)
				.HasMaxLength(50);
			
			entity.Property(e => e.State)
				.IsRequired()
				.HasMaxLength(2);
			
			entity.Property(e => e.StreetAddress)
				.IsRequired()
				.HasMaxLength(50);
			
			entity.Property(e => e.Suite)
				.HasMaxLength(50);
			
			entity.Property(e => e.Type)
				.IsRequired()
				.HasMaxLength(50);
			
			entity.Property(e => e.Zip)
				.IsRequired()
				.HasMaxLength(10);
			
			entity.HasOne(e => e.Contact)
				.WithMany(e => e.Addresses);
        }
    }
}