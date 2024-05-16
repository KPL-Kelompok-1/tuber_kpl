using Microsoft.VisualStudio.TestTools.UnitTesting;
using backend.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Model;
using Newtonsoft.Json;

namespace backend.Controllers.Tests
{
    [TestClass()]
    public class UserControllerTests
    {
        [TestMethod()]
        public void LoginTest()
        {
            var client = new HttpClient();
            var user = new Model.user()
            {
                id = 5,
                username = "Djenggo",
                password = "test1234",
                role = "Admin"
            };
            var content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");
            var response = client.PostAsync("https://localhost:7238/api/User/register", content).Result;

            // Assert

            Assert.AreEqual(200, (int)response.StatusCode);
        }
        [TestMethod()]
        public void GetTestSuccesRequest()
        {
            var client = new HttpClient();
            var response = client.GetAsync("https://localhost:7238/api/User").Result;

            // Assert
            response.EnsureSuccessStatusCode();
            Assert.AreEqual(200, (int)response.StatusCode);
        }
        [TestMethod()]
        public void GetByIdTestSuccesRequest()
        {
            var client = new HttpClient();
            var response = client.GetAsync("https://localhost:7238/api/User/1").Result;

            // Assert
            response.EnsureSuccessStatusCode();
            Assert.AreEqual(200, (int)response.StatusCode);
        }
        [TestMethod()]
        public void PostTestSuccesRequest()
        {
            var client = new HttpClient();
            var user = new Model.user()
            {
                id = 5,
                username = "Djenggo",
                password = "test1234",
                role = "Admin"
            };
            var content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");
            var response = client.PostAsync("https://localhost:7238/api/User/register", content).Result;

            // Assert

            Assert.AreEqual(200, (int)response.StatusCode);
        }
        [TestMethod()]
        public void PostTestBadRequestInputNotNull()
        {
            var client = new HttpClient();
            var user = new Model.user()
            {
                id = 5,
                username = "Djenggo",
                password = "test",
                role = "Admin"
            };
            var content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");
            var response = client.PostAsync("https://localhost:7238/api/User/register", content).Result;

            // Assert

            Assert.AreEqual(400, (int)response.StatusCode);
        }
        [TestMethod()]
        public void PutTestSuccesRequest()
        {
            var client = new HttpClient();
            var user = new Model.user()
            {
                id = 5,
                username = "Djenggo",
                password = "test1234",
                role = "Admin"
            };
            var content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");
            var response = client.PutAsync("https://localhost:7238/api/User", content).Result;
            Assert.AreEqual(200, (int)response.StatusCode);
        }
        [TestMethod()]
        public void PutTestBadRequestInputNotNull()
        {
            var client = new HttpClient();
            var user = new Model.user()
            {
                id = 5,
                username = "Djenggo",
                password = "test",
                role = "Admin"
            };
            var content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");
            var response = client.PutAsync("https://localhost:7238/api/User", content).Result;
            Assert.AreEqual(400, (int)response.StatusCode);
        }
         

    }
}