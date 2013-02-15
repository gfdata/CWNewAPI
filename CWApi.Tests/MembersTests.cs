using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SD.ConnectwiseApi;

namespace CWApi.Tests
{
    [TestClass]
    public class MembersTests
    {
        [TestMethod]
        public void FindMembersByName()
        {
            var api = new MembersApi();
            var response = api.FindMembers(MemberProperties.LastName, "Ferrie");
            Assert.IsNotNull(response);
            Assert.AreNotEqual(0, response.Count());
        }

        [TestMethod]
        public void TestMemberLogin()
        {
            var api = new MembersApi();
            var response1 = api.ValidateLogin("gferrie", "ferrie");
            Assert.IsTrue(response1);
            var response2 = api.ValidateLogin("gferrie", "ferrie!!!");
            Assert.IsFalse(response2);
        }
    }
}
