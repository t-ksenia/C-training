using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Collections.Generic;
using NUnit.Framework;


namespace addressbook_web_tests
{
    [TestFixture]
    
    public class ContactCreationTests : AuthTestBase
    {
        [Test]
        public void ContactCreationtests()
        {
           
            ContactData contact = new ContactData("Firstname", "Lastname");
            contact.Address = "London, Baker st, 221b";
            contact.Phonehome = "1234567890";
            contact.Email = "Sh.H@qwe.com";

            List<ContactData> oldContacts = app.Contacts.GetContactList();

            app.Contacts.Create(contact);

            Assert.AreEqual(oldContacts.Count + 1, app.Contacts.GetContactCount());

            List<ContactData> newContacts = app.Contacts.GetContactList();
            oldContacts.Add(contact);
            oldContacts.Sort();
            newContacts.Sort();
            Assert.AreEqual(oldContacts, newContacts);
        }

        

       

        
    }

       
    
}