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
    
    public class ContactCreationTests : TestBase
    {
        [Test]
        public void ContactCreationtests()
        {
           
            ContactData group = new ContactData("Firstname", "Lastname");
            group.Address = "London, Baker st, 221b";
            group.Phonehome = "1234567890";
            group.Email = "Sh.H@qwe.com";
            app.Contacts.Create(group);
        }

        

       

        
    }

       
    
}