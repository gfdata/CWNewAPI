using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace SD.ConnectwiseApi
{
    public sealed class InvoicesApi : ServiceBase
    {
        public IEnumerable<InvoiceInfo> FindInvoices(FindInvoiceRequest request)
        {
            var filterExpression = string.Join(" OR ", request.Filters.Select(q => q.ToString()).ToArray());
            var message = string.Format(MessageConstants.Invoices_FindInvoices, filterExpression);

            var doc = new XmlDocument();
            var resultXml = ProcessAction(message);
            doc.LoadXml(resultXml);

            return doc.DocumentElement.ChildNodes.Cast<XmlNode>()
                    .First(q => "Tickets".Equals(q.Name))
                    .ChildNodes.Cast<XmlNode>()
                    .Select(q => InvoiceInfo.Create(q));

        }
    }
}
