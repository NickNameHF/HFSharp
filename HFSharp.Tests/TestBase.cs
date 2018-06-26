using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HFSharp.Tests
{
    public abstract class TestBase
    {
        public HFClient Client { get; set; }
        public string ApiKey { get; set; }

        [TestInitialize]
        public void TestInit()
        {
            ApiKey = "YOURAPIKEY";
            Client = new HFClient(ApiKey);
        }
    }
}
