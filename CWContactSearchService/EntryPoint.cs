using SD.ConnectwiseApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CWContactSearchService
{
    public class EntryPoint
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Connectwise Contacts Service... ");


            var api = new TimeEntriesApi();
            var req = new FindTimeEntriesRequest();
            req.Filters.Add(new FilterCriteria<TimeEntryProperties> { TargetField = TimeEntryProperties.MemberID, Operation = FilterOperation.Equal, Value = "gferrie" });

            var resp = api.FindTimeEntries(req);
        }
    }

}
