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
    }
}
