using System;
using System.Collections.Generic;

namespace AddressBook.Models
{
	public class Contact
	{
		public int ContactId { get; set; }
		public string FirstName { get; set; }
		public string MiddleName { get; set; }
		public string LastName { get; set; }
		public string Suffix { get; set; }
		public DateTime? DOB { get; set; }
		public ICollection<Address> Addresses { get; set; }
	}
}