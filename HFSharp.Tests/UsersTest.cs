using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HFSharp.Tests
{
    [TestClass]
    public class UsersTest : TestBase
    {
        [TestMethod]
        public void GetUserProfile()
        {
            try
            {
                var user = Client.GetUserProfile(2918763);
                Assert.IsNotNull(user);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void GetUsersProfiles()
        {
            try
            {
                var users = Client.GetUsersProfiles(new[] { 2918763, 2947999, 2900217, 2333286 });
                Assert.IsNotNull(users);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}
