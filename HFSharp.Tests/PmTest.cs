using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HFSharp.Tests
{
    [TestClass]
    public class PmTest : TestBase
    {
        [TestMethod]
        public void GetPrivateMessage()
        {
            try
            {
                var pm = Client.GetPrivateMessage(1);
                Assert.IsNotNull(pm);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void GetPmBox()
        {
            try
            {
                var pmbox = Client.GetPmBox(1);
                Assert.IsNotNull(pmbox);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void GetInbox()
        {
            try
            {
                var inbox = Client.GetInbox();
                Assert.IsNotNull(inbox);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}
