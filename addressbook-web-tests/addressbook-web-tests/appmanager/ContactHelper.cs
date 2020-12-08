using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace addressbook_web_tests
{
    public class ContactHelper : HelperBase
    {
        public object CreateContact { get; private set; }

        public ContactHelper(ApplicationManager manager)
           : base(manager)
        {
        }

        public ContactHelper Create(ContactData contact)
        {
            manager.Navigator.GoToAddNewContact();
            InitContactCreation();
            FillContactForm(contact);
            SubmitContactCreation();
            manager.Navigator.GoToHomePage();
            return this;
        }
        public ContactHelper Remove(int q)
        {
            manager.Navigator.GoToHomePage();
            SelectContact(q);
            RemoveContact();
            ReturnToHomePage();
            return this;
        }
        public ContactHelper Modify(int q, ContactData newData)
        {
            manager.Navigator.GoToHomePage();
            SelectContact(q);
            InitContactModification();
            FillContactForm(newData);
            SubmitContactModification();
            ReturnToHomePage();
            return this;
        }

        public ContactHelper SubmitContactModification()
        {
            driver.FindElement(By.Name("update")).Click();
            return this;
        }

        public ContactHelper InitContactModification()
        {
            driver.FindElement(By.XPath("(//img[@alt='Edit'])[2]")).Click();
            return this;
        }

        public ContactHelper SubmitContactCreation()
        {
            driver.FindElement(By.XPath("(//input[@name='submit'])[2]")).Click();
            return this;
        }


        public ContactHelper FillContactForm(ContactData contact)
        {
            
            Type(By.Name("firstname"), contact.Firstname);
            Type(By.Name("lastname"), contact.Lastname);
            Type(By.Name("address"), contact.Address);
            Type(By.Name("home"), contact.Phonehome);
            Type(By.Name("email"), contact.Email);
            return this;
        }

        

        public ContactHelper InitContactCreation()
        {
            driver.FindElement(By.LinkText("add new")).Click();
            return this;
        }
        public ContactHelper SelectContact(int index)
        {
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + index + "]")).Click();
            return this;
        }
        public ContactHelper RemoveContact()

        {

            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            manager.CloseAlertAndGetItsText();
            return this;
        }

        public void CreateNewContact()
        {
            driver.FindElement(By.LinkText("add new")).Click();
            driver.FindElement(By.Name("theform")).Click();
        }

        public bool IsContactCreated()
        {
            return IsElementPresent(By.Name("Edit"));
        }
        

        public ContactHelper ReturnToHomePage()
        {
            driver.FindElement(By.LinkText("home")).Click();
            return this;
        }
    }
}

  


        