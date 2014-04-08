using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace SD.ConnectwiseApi
{
    public sealed class ClientsApi
        : ServiceBase
    {
        public IEnumerable<ServiceTicketInfo> FindServiceTickets(FindServiceTicketRequest request)
        {
            var filterExpression = string.Join(" AND ", request.Filters.Select(q => q.ToString()).ToArray());
            var message = string.Format(MessageConstants.ServiceTickets_FindTickets, filterExpression);

            var doc = new XmlDocument();
            var resultXml = ProcessAction(message);
            doc.LoadXml(resultXml);

            return doc.DocumentElement.ChildNodes.Cast<XmlNode>()
                    .First(q => "Tickets".Equals(q.Name))
                    .ChildNodes.Cast<XmlNode>()
                    .Select(q => ServiceTicketInfo.Create(q));

        }
    }
}
