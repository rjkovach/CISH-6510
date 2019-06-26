namespace AddressBook.Models
{
	public class Address
	{
		public int AddressId { get; set; }
		public string Type { get; set; }
		public string CompanyName { get; set; }
		public string StreetAddress { get; set; }
		public string Suite { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Zip { get; set; }
	}
}