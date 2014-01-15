using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SD.ConnectwiseApi;
using SD.ConnectwiseApi.Model;
using SD.ConnectwiseApi.Enum;

namespace CWApi.Tests
{
    [TestClass]
    public class ServiceTicketsTests
    {
        public ServiceTicketsTests()
        {

        }

        ServiceTicketsApi svc;

        [TestInitialize]
        public void Init()
        {
            svc = new ServiceTicketsApi();
        }

        [TestMethod]
        public void FindTickets_Test()
        {
            var request = new FindServiceTicketRequest();
            request.Filters.Add(new FilterCriteria<ServiceTicketProperties> { TargetField = ServiceTicketProperties.CompanyName, Value = "WTAS", Operation = FilterOperation.Contains });
            request.Limit = 10;

            var result = svc.FindServiceTickets(request);
            Assert.IsNotNull(result);
            Assert.AreNotEqual(0, result.Count());
        }
    }
}
