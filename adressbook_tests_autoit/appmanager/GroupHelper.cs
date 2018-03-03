using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace adressbook_tests_autoit
{
    public class GroupHelper : HelperBase
    {
        public static string GROUPWINTITLE = "Group editor";
        public GroupHelper(ApplicationManager manager) : base(manager) { }

        
        public List<GroupData> GetGroupList()
        {
            List<GroupData> list = new List<GroupData>() ;
            OpenGroupsDialog();
            string count =  aux.ControlTreeView(GROUPWINTITLE, "", "WindowsForms10.SysTreeView32.app.0.62e4491",
                "GetItemCount", "#0", "");
            for (int i = 0; i < int.Parse(count); i++)
            {
                string item =  aux.ControlTreeView(GROUPWINTITLE, "", "WindowsForms10.SysTreeView32.app.0.62e4491",
                    "GetItemCount", "#0|#" + i, "");
                list.Add(new GroupData() 
                {
                Name = item
                }
                    );
            }


                CloseGroupsDialog();
                return list;
        }



        public void Add(GroupData newGroup)
        {
           OpenGroupsDialog();
           aux.ControlClick(GROUPWINTITLE, "", "WindowsForms10.BUTTON.app.0.62e4493");
           aux.Send(newGroup.Name);
           aux.Send("{ENTER}");
           CloseGroupsDialog();

        }

        private void CloseGroupsDialog()
        {
            aux.ControlClick(GROUPWINTITLE, "", "WindowsForms10.BUTTON.app.0.62e4494");
        }

        private void OpenGroupsDialog()
        {
            aux.ControlClick(WINTITLE, "", "WindowsForms10.BUTTON.app.0.62e44912");
            aux.WinWait(GROUPWINTITLE);
        }

        public void Remove(int p)
        {
            OpenGroupsDialog();
            SelectGroup(p);
            aux.ControlClick("Group editor", "", "WindowsForms10.BUTTON.app.0.62e4491");
            SelectGroup(p);
            aux.ControlClick("Delete group", "", "WindowsForms10.BUTTON.app.0.62e4493");
            CloseGroupsDialog();
           
        }

        public void SelectGroup(int p)
        {
             string count = aux.ControlTreeView(GROUPWINTITLE, "", "WindowsForms10.SysTreeView32.app.0.62e4491",
                "Select", "#0|#0"+p, "");
        }
    }
}
