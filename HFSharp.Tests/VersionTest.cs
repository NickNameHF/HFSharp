using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HFSharp.Tests
{
    [TestClass]
    public class VersionTest : TestBase
    {
        [TestMethod]
        public void GetCurrentApiVersion()
        {
            try
            {
                var version = Client.GetCurrentApiVersion();
                Assert.IsNotNull(version);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}
