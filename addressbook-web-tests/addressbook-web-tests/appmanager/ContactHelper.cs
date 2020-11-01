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
        public ContactHelper(ApplicationManager manager)
           : base(manager)
        {
        }

        public ContactHelper Create(ContactData group)
        {
            manager.Navigator.GoToAddNewContact();
            InitContactCreation();
            FillContactForm(group);
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


        public ContactHelper FillContactForm(ContactData group)
        {
            
            Type(By.Name("firstname"), group.Firstname);
            Type(By.Name("lastname"), group.Lastname);
            Type(By.Name("address"), group.Address);
            Type(By.Name("home"), group.Phonehome);
            Type(By.Name("email"), group.Email);
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

        

        public ContactHelper ReturnToHomePage()
        {
            driver.FindElement(By.LinkText("home")).Click();
            return this;
        }
    }
}

        