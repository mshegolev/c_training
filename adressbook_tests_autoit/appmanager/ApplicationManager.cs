﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoItX3Lib;


namespace adressbook_tests_autoit
{
    public class ApplicationManager
    {
        public static string WINTITLE = "Free Address Book";
        private AutoItX3 aux;
        private GroupHelper groupHelper;
        private ContactHelper contactHelper;
        
        public ApplicationManager()
        {
            aux = new AutoItX3();
           // aux.Run(@"C:\wamp\tools\addressbook_win\AddressBook.exe", "", aux.SW_SHOW);
            aux.Run(@"D:\galina\job\курсы\FreeAddressBookPortable\AddressBook.exe", "", aux.SW_SHOW);
            aux.WinWait(WINTITLE);
            aux.WinActivate(WINTITLE);
            aux.WinWaitActive(WINTITLE);

            groupHelper = new GroupHelper(this);
            contactHelper = new ContactHelper(this);
        }

        public void Stop()
        {
            aux.ControlClick(WINTITLE, "", "WindowsForms10.BUTTON.app.0.62e44910");
        }

        public AutoItX3 Aux
        {
            get { return aux; }
        }
        public GroupHelper Groups
        {
            get {return groupHelper ;}
        }

        public ContactHelper Contacts
        {
            get { return contactHelper; }
        }
    }
}
