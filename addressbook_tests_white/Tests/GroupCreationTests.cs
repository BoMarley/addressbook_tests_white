using NUnit.Framework;
using System.Collections.Generic;

namespace addressbook_tests_white
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void TestGroupCreation()
        {
            //prepare
            List<GroupData> oldGrops = app.Groups.GetGroupList();

            //action
            GroupData newGroup = new GroupData()
            {
                Name = "New group"
            };
            app.Groups.Add(newGroup);

            //validation
            List<GroupData> newGrops = app.Groups.GetGroupList();
            oldGrops.Add(newGroup);
            oldGrops.Sort();
            newGrops.Sort();
            Assert.AreEqual(oldGrops, newGrops);
        }
    }
}