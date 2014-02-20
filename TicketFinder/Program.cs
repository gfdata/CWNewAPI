using SD.ConnectwiseApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicketFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter 1 or more service ticket ids: ");
            var invnumText = Console.ReadLine();

            var invnums = invnumText.Split(new [] { ',', ' ', ';' }, StringSplitOptions.RemoveEmptyEntries);

            var limit = invnums.Length;

            var request = new FindInvoiceRequest();
            request.Limit = limit;

            foreach(var ticket in invnums) {
                request.Filters.Add(new FilterCriteria<InvoiceProperties> { TargetField = InvoiceProperties.InvoiceNumber, Value = ticket, Operation = FilterOperation.Equal });
            }

            var svc = new InvoicesApi();
            var result = svc.FindInvoices(request);
            //foreach (var group in result.GroupBy(q => q.BoardName))
            //{
            //    Console.WriteLine(group.Key);
            //    foreach (var item in group)
            //    {
            //        Console.WriteLine("\t\tSummary: {0}, {1}, {2}", item.Summary, item.ContactName, item.CompanyName);
            //    }
            //}


            Console.WriteLine("\n\n\nDone!");
            Console.ReadLine();
        }
    }
}
