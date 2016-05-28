using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CISH6510.AddressBook.Models;

namespace CISH6510.AddressBook.Controllers
{
    [Route("api/[controller]")]
    public class ContactsController : Controller
    {
		private AddressBookContext _db;
		
		public ContactsController(AddressBookContext db)
		{
			_db = db;
		}
		
        // GET: api/contacts
        [HttpGet]
        public async Task<IEnumerable<Contact>> Get()
        {
            return await _db.Contacts.ToListAsync();
        }

        // GET api/contacts/5
        [HttpGet("{contactId}", Name = "GetContact")]
        public async Task<IActionResult> Get(int contactId)
        {
			var contact = await _db.Contacts.Include(c => c.Addresses).FirstAsync(c => c.ContactId == contactId);
			
			if (contact == null)
				return NotFound();
			
            return Ok(contact);
        }

        // POST api/contacts
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Contact contact)
        {
			if (contact == null)
				return BadRequest();
			
			_db.Contacts.Add(contact);
			await _db.SaveChangesAsync();
			
			return CreatedAtRoute("GetContact", new { controller = "Contacts", contactId = contact.ContactId }, contact);
        }

        // PUT api/contacts/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int contactId, [FromBody] Contact contact)
        {
            if ((contact == null) || (contact.ContactId != contactId))
                return BadRequest();
            
            var existingContact = await _db.Contacts.FirstAsync(c => c.ContactId == contactId);
            
            if (existingContact == null)
                return NotFound();
            
            existingContact.FirstName = contact.FirstName;
            existingContact.MiddleName = contact.MiddleName;
            existingContact.LastName = contact.LastName;
            existingContact.Suffix = contact.Suffix;
            existingContact.DOB = contact.DOB;
            
            await _db.SaveChangesAsync();
            
            return NoContent();
        }

        // DELETE api/contacts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int contactId)
        {
            var contact = await _db.Contacts.FirstAsync(c => c.ContactId == contactId);
            
            if (contact == null)
                return NotFound();
            
            _db.Contacts.Remove(contact);
            await _db.SaveChangesAsync();
            
            return NoContent();
        }
    }
}