using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace adressbook_tests_autoit
{
    [TestFixture]
    class GroupRemovalTests : TestBase
    {
        [Test]
        public void TestGroupRemov() 
        {

            List<GroupData> oldGroups = app.Groups.GetGroupList();
            GroupData oldData = oldGroups[0];
            app.Groups.Remove(0);

            Console.WriteLine(oldGroups.Count);

            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups.RemoveAt(0);
            Console.WriteLine(oldGroups.Count);

            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);

        }

        
       
    }
}
