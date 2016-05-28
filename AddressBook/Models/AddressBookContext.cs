using Microsoft.EntityFrameworkCore;
using CISH6510.AddressBook.Models.Configuration;

namespace CISH6510.AddressBook.Models
{
	public partial class AddressBookContext : DbContext
	{
		public AddressBookContext(DbContextOptions<AddressBookContext> options)
			: base(options)
		{
		}
		
		public DbSet<Address> Addresses { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.AddConfiguration<Address, AddressConfiguration>();
			modelBuilder.AddConfiguration<Contact, ContactConfiguration>();
		}
	}
}