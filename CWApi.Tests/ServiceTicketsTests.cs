using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SD.ConnectwiseApi;

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
            
        }

        [TestMethod]
        public void FindTickets_Test()
        {
            var request = new FindServiceTicketRequest();
            request.Filters.Add(new FilterCriteria<ServiceTicketProperties> { TargetField = ServiceTicketProperties.SRServiceRecID, Value = "16898", Operation = FilterOperation.Equal });
            request.Limit = 10;

            var result = svc.FindServiceTickets(request);
            Assert.IsNotNull(result);
            Assert.AreNotEqual(0, result.Count());
        }
    }
}
