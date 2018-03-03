using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace adressbook_tests_autoit
{
    [TestFixture]

    public class ContactRemovalTests : TestBase
    {

        [Test]
        //для удаления контакта без проверки
        public void TestContactRemove()
        {
            
            app.Contacts.RemoveCont();

            

        }

        //для удаления контакта с проверкой
        [Test]
        public void TestContactRemovePr()
        {
            List<ContactData> oldContacts = app.Contacts.GetContactList();
            ContactData oldContact = oldContacts[0];
            app.Contacts.RemoveCont();

            Console.WriteLine(oldContacts.Count);

            List<ContactData> newContacts = app.Contacts.GetContactList();
            oldContacts.RemoveAt(0);
            Console.WriteLine(oldContacts.Count);

            oldContacts.Sort();
            newContacts.Sort();

            Assert.AreEqual(oldContacts, newContacts);
        }
    }
}
