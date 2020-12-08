using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

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
            app.Contacts.Create(contact);
        }

        

       

        
    }

       
    
}