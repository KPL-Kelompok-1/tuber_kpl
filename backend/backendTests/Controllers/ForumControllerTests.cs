using Microsoft.VisualStudio.TestTools.UnitTesting;
using backend.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using backend.Model;
using Newtonsoft.Json;


namespace backend.Controllers.ResponseTest
{
    [TestClass()]
    public class ForumControllerTests
    {
        [TestMethod()]
        public void GetTestSuccesRequest()
        {
            var client = new HttpClient();
            var response = client.GetAsync("https://localhost:7238/api/Forum").Result;

            // Assert
            response.EnsureSuccessStatusCode();
            Assert.AreEqual(200, (int)response.StatusCode);
        }

        [TestMethod()]
        public void GetByIdTestSuccesRequest()
        {
            var client = new HttpClient();
            var response = client.GetAsync("https://localhost:7238/api/Forum/1").Result;

            // Assert
            response.EnsureSuccessStatusCode();
            Assert.AreEqual(200, (int)response.StatusCode);
        }

        [TestMethod()]
        public void PostTestSuccesRequest()
        {
            var client = new HttpClient();
            var forum = new Model.Forum()
            {
                id = 5,
                title = "Hello",
                content = "test1234",
                created_at = DateTime.Now.ToString(),
                comments = [ new Comment()
                    {
                        id = 1,
                        content = "comment 1",
                        created_at = DateTime.Now.ToString()
                    }]
            };
            var content = new StringContent(JsonConvert.SerializeObject(forum), Encoding.UTF8, "application/json");
            var response = client.PostAsync("https://localhost:7238/api/Forum", content).Result;

            // Assert
      
            Assert.AreEqual(200, (int)response.StatusCode);
        }
        [TestMethod()]
        public void PostTestBadRequestInputNotNull()
        {
            var client = new HttpClient();
            var forum = new Model.Forum()
            {
                id = 5,
                title = "",
                content = "",
                created_at = DateTime.Now.ToString(),
                comments = [ new Comment()
                    {
                        id = 1,
                        content = "comment 1",
                        created_at = DateTime.Now.ToString()
                    }]
            };
            var content = new StringContent(JsonConvert.SerializeObject(forum), Encoding.UTF8, "application/json");
            var response = client.PostAsync("https://localhost:7238/api/Forum", content).Result;

            // Assert

            Assert.AreEqual(400, (int)response.StatusCode);
        }

        [TestMethod()]
        public void PutTestSuccesRequest()
        {
            var client = new HttpClient();
            var forum = new Model.Forum()
            {
                id = 5,
                title = "Hello",
                content = "test12345",
                created_at = DateTime.Now.ToString(),
                comments = [ new Comment()
                                   {
                        id = 1,
                        content = "comment 1",
                        created_at = DateTime.Now.ToString()
                    }]
            };
            var content = new StringContent(JsonConvert.SerializeObject(forum), Encoding.UTF8, "application/json");
            var response = client.PutAsync("https://localhost:7238/api/Forum/5/update", content).Result;
            Assert.AreEqual(200, (int)response.StatusCode);
        }
        [TestMethod()]
        public void PutTestBadRequestInputNotNull()
        {
            var client = new HttpClient();
            var forum = new Model.Forum()
            {
                id = 5,
                title = "",
                content = "",
                created_at = DateTime.Now.ToString(),
                comments = [ new Comment()
                                   {
                        id = 1,
                        content = "comment 1",
                        created_at = DateTime.Now.ToString()
                    }]
            };
            var content = new StringContent(JsonConvert.SerializeObject(forum), Encoding.UTF8, "application/json");
            var response = client.PutAsync("https://localhost:7238/api/Forum/5/update", content).Result;
            Assert.AreEqual(400, (int)response.StatusCode);
        }

        [TestMethod()]
        public void DeleteTestSuccesRequest()
        {
            var client = new HttpClient();
            var response = client.DeleteAsync("https://localhost:7238/api/Forum/5/delete").Result;
            Assert.AreEqual(200, (int)response.StatusCode);
        }
    }
}