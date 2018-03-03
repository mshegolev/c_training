using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using System.Threading.Tasks;



namespace mantis_projects
{
    public class APIHelper : HelperBase
    {
        public string baseURL;
        public APIHelper(ApplicationManager manager) : base(manager)
        {
        }


        public void CreatNewProjectAPI(AccountData account, ProjectData projectData)
        {
           
            Mantis.MantisConnectPortTypeClient client = new Mantis.MantisConnectPortTypeClient();
            Mantis.ProjectData proj = new Mantis.ProjectData();
            proj.name = projectData.Name;
            if (client.mc_project_get_id_from_name(account.Username, account.password, proj.name) != "0")
            {
               Console.WriteLine("проект " + projectData.Name + " был создан ранее. id = " + client.mc_project_get_id_from_name(account.Username, account.password, proj.name));
              }
            else
            {
                client.mc_project_add(account.Username, account.password, proj);
                Console.WriteLine("Создан проект " + projectData.Name);
            }
        }

        public void DeleteProjectAPI(AccountData account, ProjectData projectData)
        {
            Mantis.MantisConnectPortTypeClient client = new Mantis.MantisConnectPortTypeClient();
            Mantis.ProjectData proj = new Mantis.ProjectData();
            proj.name = projectData.Name;
            string projectId = client.mc_project_get_id_from_name(account.Username, account.password, proj.name);
            if (projectId == "0")
            { client.mc_project_add(account.Username, account.password, proj);
            Console.WriteLine("Проект создан");
             projectId = client.mc_project_get_id_from_name(account.Username, account.password, proj.name);
           
            }
            
            client.mc_project_delete(account.Username, account.password, projectId);
            Console.WriteLine("Проект удален");
        }
    }
}
