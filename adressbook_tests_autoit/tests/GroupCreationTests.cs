using System;
using System.Collections.Generic;
using NUnit.Framework;



namespace adressbook_tests_autoit
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void TestGroupCreation()
        {
            List<GroupData> oldGroups = app.Groups.GetGroupList();

            GroupData newGroup = new GroupData()
            {
                Name = "Антон Петрович"
            };

            app.Groups.Add(newGroup);

            List<GroupData> newGroups = app.Groups.GetGroupList();

            oldGroups.Add(newGroup);
            Assert.AreEqual(oldGroups.Count, newGroups.Count);
            //Console.WriteLine(oldGroups.Count);
            //Console.WriteLine(newGroups.Count);


            oldGroups.Sort();
            newGroups.Sort();

            Assert.AreEqual(oldGroups, newGroups);



        }
    }
}
