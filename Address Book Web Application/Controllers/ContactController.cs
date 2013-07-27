using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CISH6510.AddressBook.Model;

namespace CISH6510.AddressBook.Web.Controllers
{
	public class ContactController : ApiController
	{
		// GET api/<controller>
		public IEnumerable<Contact> Get()
		{
			using (var db = new AddressBookEntities())
			{
				return db.Contacts.ToArray();
			}
		}

		// GET api/<controller>/5
		public Contact Get(int id)
		{
			using (var db = new AddressBookEntities())
			{
				return db.Contacts.Find(id);
			}
		}

		// POST api/<controller>
		public void Post([FromBody]string value)
		{
		}

		// PUT api/<controller>/5
		public void Put(int id, [FromBody]string value)
		{
		}

		// DELETE api/<controller>/5
		public void Delete(int id)
		{
			using (var db = new AddressBookEntities())
			{
				var contact = db.Contacts.Find(id);

				// Remove existing contact
				if (contact != null)
				{
					db.Contacts.Remove(contact);
					db.SaveChanges();
				}
			}
		}
	}
}