using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace mantis_projects
{
    public class NavigationHelper : HelperBase
    {
        public string baseURL;
       
        public NavigationHelper(ApplicationManager manager, string baseURL )
            : base(manager)
        {
            this.baseURL = baseURL;
        }

        public void GoToHomePage()
        {
            driver.Navigate().GoToUrl(baseURL + "/mantisbt-1.2.17/");
            
        }

        public void GoToAdminPage()
        {
            driver.Navigate().GoToUrl(baseURL + "/mantisbt-1.2.17/login_page.php");
            driver.FindElement(By.Name("username")).Clear();
            driver.FindElement(By.Name("username")).SendKeys("administrator");
            driver.FindElement(By.Name("password")).Clear();
            driver.FindElement(By.Name("password")).SendKeys("root");
            driver.FindElement(By.CssSelector("input.button")).Click();
        }

        public void GoToManage()
        {
            driver.FindElement(By.LinkText("Manage")).Click();
        }

        public void GoToProjects()
        {
            driver.FindElement(By.LinkText("Manage Projects")).Click();
        }

        public void GoToCreatProjectForm()
        {
            driver.FindElement(By.CssSelector("td.form-title > form > input.button-small")).Click();
        }



        public void Logout()
        {
            driver.FindElement(By.LinkText("Logout")).Click();
        }
    }
}
