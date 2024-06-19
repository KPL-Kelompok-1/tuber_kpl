using Microsoft.VisualStudio.TestTools.UnitTesting;
using FrontEnd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrontEnd;
using Model;

namespace FrontEnd.Tests
{
    [TestClass()]
    public class transitionLoginTests
    {
        [TestMethod()]
        public void getRoleTest()
        {
            transitionLogin.getRole(transitionLogin.Role.USER);
            string roles = transitionLogin.getRole(transitionLogin.Role.USER);
            Assert.AreEqual("USER" , roles);
        }
        [TestMethod()]
        public void getRoleTestisnull()
        {
            transitionLogin.getRole(transitionLogin.Role.TEST);
            string roles = transitionLogin.getRole(transitionLogin.Role.TEST);
            Assert.IsNull(roles);
        }
    }
}