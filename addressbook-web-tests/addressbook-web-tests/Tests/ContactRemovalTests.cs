using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace addressbook_web_tests
{
    public class ContactRemovalTests : TestBase
    {

        [Test]
        public void RemoveContactTest()

        {
            app.Contacts.Remove(2);

        }








    }
}
