using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using System.Threading.Tasks;


namespace mantis_projects
{
    public class LoginHelper : HelperBase
    {
        public string baseURL;
        public string adminLogin;
        public string adminPassword;

        public LoginHelper(ApplicationManager manager, string baseURL, string adminLogin, string adminPassword)
            : base(manager)
        {this.baseURL = baseURL;
        this.adminLogin = adminLogin;
        this.adminPassword = adminPassword;
        }


        public LoginHelper(ApplicationManager manager)
            : base(manager)
        { }

        

              
        public void Login(AccountData account)
        {
            if (IsLoggedIn())
            {
               Logout();
            }
           
            driver.Navigate().GoToUrl(baseURL + "/mantisbt-1.2.17/login_page.php");
              }

        public bool IsLoggedIn()
        {
            return IsElementPresent(By.Name("logout"));
        }

       
        public void Logout()
        {
            if (IsLoggedIn())
            {
               
                driver.FindElement(By.LinkText("Logout")).Click();
            }

        }
    }
}
