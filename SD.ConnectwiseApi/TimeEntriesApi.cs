using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace SD.ConnectwiseApi
{
    
    public class TimeEntriesApi : ServiceBase
    {
        public IEnumerable<TimeEntryInfo> FindTimeEntries(FindTimeEntriesRequest request)
        {
            var filterExpression = string.Join(" AND ", request.Filters.Select(q => q.ToString()).ToArray());
            var message = string.Format(MessageConstants.TimeEntry_FindTimeEntries, filterExpression);

            var doc = new XmlDocument();
            var resultXml = ProcessAction(message);
            doc.LoadXml(resultXml);


            return doc.DocumentElement.ChildNodes.Cast<XmlNode>()
                .First(q => "TimeEntries".Equals(q.Name))
                .ChildNodes.Cast<XmlNode>()
                .Select(q => TimeEntryInfo.Create(q));
        }
    }
}
