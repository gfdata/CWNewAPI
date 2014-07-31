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

            // Run Service
            ServiceHost sh = new ServiceHost(typeof(CWContacts));
            sh.Open();
            Console.WriteLine("Url: sb://sdphonelist.servicebus.windows.net/contactsearch");
            Console.WriteLine("Press ENTER to close");
            Console.ReadLine();
            sh.Close();

            // :: Test API :: 
            //Console.Write("Search query: ");
            //var query = Console.ReadLine();

            //var service = new ContactsApi();
            //var request = new FindContactsRequest();
            //request.Filters.Add(new FilterCriteria<ContactProperties> { 
            //    TargetField = ContactProperties.LastName, 
            //    Operation = FilterOperation.Like,
            //    Value = query });
            //var results = service.FindContacts(request);
            //foreach (var item in results)
            //{
            //    Console.WriteLine("{0} {1} - {2}", item.FirstName, item.LastName, item.CompanyName);
            //}
        }
    }
}
