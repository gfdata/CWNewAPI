using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace SD.ConnectwiseApi
{
    public sealed class ContactsApi : ServiceBase
    {
        public IEnumerable<ContactInfo> FindContacts(FindContactsRequest request)
        {
            var filterExpression = string.Join(" AND ", request.Filters.Select(q => q.ToString()).ToArray());
            var message = string.Format(MessageConstants.Contacts_FindContacts, filterExpression);

            var doc = new XmlDocument();
            var resultXml = ProcessAction(message);
            doc.LoadXml(resultXml);


            return doc.DocumentElement.ChildNodes.Cast<XmlNode>()
                .First(q => "Contacts".Equals(q.Name))
                .ChildNodes.Cast<XmlNode>()
                .Select(q => ContactInfo.Create(q));
        }
    }
}
