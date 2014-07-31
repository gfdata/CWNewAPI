using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SD.ConnectwiseApi;

namespace CWApi.Tests
{
    [TestClass]
    public class ContactServicesTests
    {
        [TestMethod]
        public void FindContacts()
        {
            var api = new ContactsApi();
            var req = new FindContactsRequest();
            req.Filters.Add(new FilterCriteria<ContactProperties> { Operation = FilterOperation.Like, TargetField = ContactProperties.LastName, Value = "Cast*" });
            api.FindContacts(req);
        }
    }
}
