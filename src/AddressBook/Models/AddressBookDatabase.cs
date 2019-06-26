using Microsoft.EntityFrameworkCore;

namespace AddressBook.Models
{
	public class AddressBookDatabase : DbContext
	{
		public AddressBookDatabase(DbContextOptions options)
			: base(options)
		{
		}

		public DbSet<Contact> Contacts { get; set; }
	}
}