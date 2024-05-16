using Microsoft.VisualStudio.TestTools.UnitTesting;
using backend.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Model;

namespace backend.Config.Tests
{
    [TestClass()]
    public class ForumConfigTests
    {

        [TestMethod()]
        public void LoadConfig_NoFile_ReturnsEmptyList()
        {
            var result = ForumConfig.LoadConfig();
            Assert.IsNotNull(result);
        }

        [TestMethod()]
        public void Add_Forum_SavesToFile()
        {
            var forum = new Forum { id = 7, title = "Test Forum", content = "This is a test." };
            ForumConfig.Add(forum);
            var result = ForumConfig.LoadConfig(7);
            Assert.AreEqual("Test Forum", result[0].title);
        }

        [TestMethod()]
        public void Edit_Forum_UpdatesInFile()
        {
            var forum = new Forum { id = 8, title = "Test Forum", content = "This is a test." };
            ForumConfig.Add(forum);

            forum.title = "Test Forum 2";
            ForumConfig.Edit(forum, 8);
            var result = ForumConfig.LoadConfig(8);

            // Assert
            Assert.AreEqual("Test Forum 2", result[0].title);
            Assert.AreEqual("This is a test.", result[0].content);
        }


        [TestMethod()]
        public void LoadConfig_WithId_ReturnsCorrectForum()
        {
            var forum1 = new Forum { id = 8, title = "Test Forum 1", content = "This is a test 1." };
            ForumConfig.Add(forum1);
            var result = ForumConfig.LoadConfig(8);
            Assert.AreEqual("Test Forum 1", result[0].title);
        }

        [TestMethod()]
        public void Delete_Forum_RemovesFromFile()
        {
            var forum = new Forum { id = 7, title = "Test Forum", content = "This is a test." };
            ForumConfig.Add(forum);
            ForumConfig.Delete(7);
            var result = ForumConfig.LoadConfig(7);
            Assert.AreEqual(1, result.Count);
        }
    }
}