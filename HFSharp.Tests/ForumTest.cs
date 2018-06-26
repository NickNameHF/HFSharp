using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HFSharp.Tests
{
    [TestClass]
    public class ForumTest : TestBase
    {
        [TestMethod]
        public void GetCategory()
        {
            try
            {
                var category = Client.GetCategory(1);
                Assert.IsNotNull(category);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void GetForum()
        {
            try
            {
                var forum = Client.GetForum(114);
                Assert.IsNotNull(forum);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void GetThread()
        {
            try
            {
                var thread = Client.GetThread(5814574);
                Assert.IsNotNull(thread);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void GetPost()
        {
            try
            {
                var post = Client.GetPost(57060351);
                Assert.IsNotNull(post);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void GetGroup()
        {
            try
            {
                var group = Client.GetGroup(36);
                Assert.IsNotNull(group);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}
