using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;


namespace mantis_projects
{
    [TestFixture]
    public class NewProjectAPI : TestBase
    {
        [Test]
        public void AddNewProjectAPI()
        {
            AccountData account = new AccountData()
            {
                Username = "administrator",
                Password = "root"
            };

            ProjectData projectData = new ProjectData()
            {
                Name = "test project1"
            };

            app.API.CreatNewProjectAPI(account, projectData);

        }

       

        [Test]

        public void DeleteProjectAPI()
        {
            AccountData account = new AccountData()
            {
                Username = "administrator",
                Password = "root"
            };

            ProjectData projectData = new ProjectData()
            {
                Name = "test project1"
            };

            app.API.DeleteProjectAPI(account, projectData);
        }
    }
}
