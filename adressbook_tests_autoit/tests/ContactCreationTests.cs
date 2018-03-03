using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace adressbook_tests_autoit
{
   [TestFixture]

    public class ContactCreationTests1 : TestBase
    {

       [Test]
       public void TestContactCreation()
       {
           List<ContactData> oldContacts = app.Contacts.GetContactList();
          ContactData newContact = new ContactData()
           {
               FirstName = "Петр",
               Identifire = "1",
               LastName = "Петров",
               MiddleName = "Петрович",
               Title = "Пятак",
               Phone = "123"

           };

           app.Contacts.AddContact(newContact);

           List<ContactData> newContacts = app.Contacts.GetContactList();

           oldContacts.Add(newContact);
           Assert.AreEqual(oldContacts.Count, newContacts.Count);

         //  Console.WriteLine(oldContacts.Count);
         //  Console.WriteLine(newContacts.Count);

           oldContacts.Sort();
           newContacts.Sort();

           Assert.AreEqual(oldContacts, newContacts);
       }
    }
}
