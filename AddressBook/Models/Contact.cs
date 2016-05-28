using System;
using System.Collections.Generic;

namespace CISH6510.AddressBook.Models
{
	public partial class Contact
	{
		public Contact()
		{
			Addresses = new HashSet<Address>();
		}
		
		public int ContactId { get; set; }
		public string FirstName { get; set; }
		public string MiddleName { get; set; }
		public string LastName { get; set; }
		public string Suffix { get; set; }
		public DateTime? DOB { get; set; }
		
		public virtual ICollection<Address> Addresses { get; set; }
	}
}