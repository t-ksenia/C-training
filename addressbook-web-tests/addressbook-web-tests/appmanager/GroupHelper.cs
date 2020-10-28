﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace addressbook_web_tests
{
    public class GroupHelper : HelperBase
    {
       

        public GroupHelper(IWebDriver driver) : base(driver)
        {
        }
        public void InitGroupCreation()
        {

            driver.FindElement(By.XPath("(//input[@name='new'])[2]")).Click();
        }
        public void FillGroupForm(GroupData group)
        {

            driver.FindElement(By.Name("group_header")).Click();
            driver.FindElement(By.Name("group_name")).Click();
            driver.FindElement(By.Name("group_name")).Clear();
            driver.FindElement(By.Name("group_name")).SendKeys(group.Name);
            driver.FindElement(By.Name("group_header")).Click();
            driver.FindElement(By.Name("group_header")).Clear();
            driver.FindElement(By.Name("group_header")).SendKeys(group.Header);
            driver.FindElement(By.Name("group_footer")).Click();
            driver.FindElement(By.Name("group_footer")).Clear();
            driver.FindElement(By.Name("group_footer")).SendKeys(group.Footer);
        }
        public void SubmitGroupCreation()
        {

            driver.FindElement(By.Name("submit")).Click();
        }
        public void ReturnToGroupPage()
        {

            driver.FindElement(By.LinkText("group page")).Click();
            driver.FindElement(By.LinkText("Logout")).Click();
        }
        public void Selectgroup(int index)
        {
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + index + "]")).Click();
        }
        public void RemoveGroup()
        {
            driver.FindElement(By.XPath("(//input[@name='delete'])[2]")).Click();
        }
    }
}
