using Newtonsoft.Json;

namespace CISH6510.AddressBook.Models
{
	public partial class Address
	{
		public int AddressId { get; set; }
		public int ContactId { get; set; }
		public string Type { get; set; }
		public string CompanyName { get; set; }
		public string StreetAddress { get; set; }
		public string Suite { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Zip { get; set; }
		
		[JsonIgnore]
		public Contact Contact { get; set; }
	}
}