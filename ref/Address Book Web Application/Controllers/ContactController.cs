﻿using System;
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
				return db.Contacts.Include("Addresses").SingleOrDefault(c => c.ContactId == id);
			}
		}

		// POST api/<controller>
		public HttpResponseMessage Post([FromBody]Contact value)
		{
			using (var db = new AddressBookEntities())
			{
				var contact = db.Contacts.Add(value);
				db.SaveChanges();
				var response = Request.CreateResponse(HttpStatusCode.Created, contact);
				response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = contact.ContactId }));
				return response;
			}
		}

		// PUT api/<controller>/5
		public void Put(int id, [FromBody]Contact value)
		{
			using (var db = new AddressBookEntities())
			{
				var contact = db.Contacts.Find(id);

				// Update existing contact
				if (contact != null)
				{
					contact.FirstName = value.FirstName;
					contact.MiddleName = value.MiddleName;
					contact.LastName = value.LastName;
					contact.Suffix = value.Suffix;
					contact.DOB = value.DOB;
					db.SaveChanges();
				}
			}
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