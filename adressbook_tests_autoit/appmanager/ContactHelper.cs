using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adressbook_tests_autoit
{
   public class ContactHelper : HelperBase
    {

       public static string CONTACTWINTITLE = "Contact Editor"; 
       public ContactHelper (ApplicationManager manager) : base(manager) { }


         public List<ContactData> GetContactList()
         {
             List<ContactData> list = new List<ContactData>();
       //      OpenContactsDialog();
             string text =  aux.ControlGetText (WINTITLE, "", "WindowsForms10.Window.8.app.0.62e44910");
            
             Console.WriteLine ("text = " + text);
             // for (int i = 0; i < int.Parse(text); i++)
            // {
             //     string item = aux.ControlGetText(WINTITLE, "", "WindowsForms10.Window.8.app.0.62e44910",
            //         "GetItemCount", "#0|#" + i, "");
            //     list.Add(new ContactData()

            //{
            //    FirstName = item
            //}
            //    );
            // }

             CloseContactsDialog();
             return list;

         }

         private void CloseContactsDialog()
         {
             aux.ControlClick(CONTACTWINTITLE, "", "WindowsForms10.BUTTON.app.0.62e4498");
         }

         private void OpenContactsDialog()
         {
             aux.ControlClick(WINTITLE, "", "WindowsForms10.BUTTON.app.0.62e4498");
            aux.WinWait(CONTACTWINTITLE);
            
         }

         public void AddContact(ContactData newContact)
         {
             OpenContactsDialog();
             aux.Send(newContact.Identifire);
             aux.Send("{TAB}");
             aux.Send("{TAB}");
             aux.Send(newContact.FirstName);
             aux.Send("{TAB}");
             aux.Send("{TAB}"); 
             aux.Send(newContact.LastName);
             aux.Send("{ENTER}");
             ////CloseContactsDialog();
         }

         public void RemoveCont()
         {
             aux.ControlClick(WINTITLE, "", "WindowsForms10.BUTTON.app.0.62e4499");
             aux.WinWait("Question");
             aux.ControlClick("Question", "", "Button1");
         }
    }
}
