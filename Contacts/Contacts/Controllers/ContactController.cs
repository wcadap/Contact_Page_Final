using Contacts.Helpers;
using Contacts.Models;
using System.Web.Mvc;
using System.Linq;
using System.Net;

namespace Contacts.Controllers
{
    public class ContactController : JsonController
    {
        private ContactContext ContactsDB = new ContactContext();
        
        public ActionResult GetContacts()
        {
            var Contacts = ContactsDB.Contacts;
            return Json(Contacts, JsonRequestBehavior.AllowGet);
        }

        public ActionResult AddContact(Contact _Contact)
        {
            try
            {
                ContactsDB.Contacts.Add(_Contact);
                ContactsDB.SaveChanges();
                return new HttpStatusCodeResult(HttpStatusCode.Created);  // OK = 200
            } catch
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest); 
            }
        }

        public ActionResult UpdateContact(Contact _Contact)
        {
            try
            {
                ContactsDB.Entry(_Contact).State = System.Data.Entity.EntityState.Modified;
                ContactsDB.SaveChanges();
                return new HttpStatusCodeResult(HttpStatusCode.Accepted);
            } catch
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest); 
            }
        }

        public ActionResult DeleteContact(int id)
        {
            var _Contact = ContactsDB.Contacts.First(r => r.Id == id);
            try {
                ContactsDB.Contacts.Remove(_Contact);
                ContactsDB.SaveChanges();
                return new HttpStatusCodeResult(HttpStatusCode.OK);  // OK = 200
            }
            catch
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest); 
            }
        }
	}
}