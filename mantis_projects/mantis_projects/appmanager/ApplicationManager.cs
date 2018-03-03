using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;



namespace mantis_projects
{
    public class ApplicationManager
    {
        protected IWebDriver driver;
        protected string baseURL;
        protected LoginHelper loginHelper;
        protected NavigationHelper navigator;
        protected string adminLogin;
        protected string adminPassword;

        protected ProjectHelper projectHelper;
     
        private static ThreadLocal<ApplicationManager> app = new ThreadLocal<ApplicationManager>();
        
        
        private ApplicationManager()
        {
            driver = new ChromeDriver();
            baseURL = "http://localhost";
            adminLogin = "administrator";
            adminPassword = "root";

            loginHelper = new LoginHelper(this, baseURL, adminLogin, adminPassword);
            navigator = new NavigationHelper(this, baseURL);
            projectHelper = new ProjectHelper(this);
            API = new APIHelper(this);

         
        }

        public static ApplicationManager GetInstance()
        {
            if (!app.IsValueCreated)
            {
                ApplicationManager newInstance = new ApplicationManager();

                newInstance.Navigator.GoToHomePage();
          
                app.Value = newInstance;

            }
            return app.Value;
        }

       
        public IWebDriver Driver
        {
            get
            {
                return driver;
            }
        }

        public LoginHelper Auth
        {
            get
            {
                return loginHelper;
            }
        }
        public NavigationHelper Navigator
        {
            get
            {
                return navigator;
            }
        }

        public LoginHelper Login
        {
            get
            {
                return loginHelper;
            }
        }
        
        public ProjectHelper Projects
        {
            get
            {
                return projectHelper;
            }
        }


        public APIHelper API { get; set; }
    }
}
