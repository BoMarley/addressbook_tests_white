using NUnit.Framework;
using System.Collections.Generic;

namespace addressbook_tests_white
{
    [TestFixture]

    public class GroupRemovalTests : TestBase

    {
        [Test]
        public void TestGroupRemoval()
        {
            //prepare
            if (!app.Groups.IsMoreThenOne())
            {
                GroupData newGroup = new GroupData()
                {
                    Name = "delete me"
                };
                app.Groups.Add(newGroup);
            }
            List<GroupData> oldGrops = app.Groups.GetGroupList();
            GroupData toBeRemoved = oldGrops[0];

            //action
            app.Groups.Remove(toBeRemoved);

            //validation
            List<GroupData> newGrops = app.Groups.GetGroupList();
            oldGrops.RemoveAt(0);
            Assert.AreEqual(oldGrops, newGrops);
        }
    }
}
