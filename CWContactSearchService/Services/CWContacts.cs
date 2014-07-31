using SD.ConnectwiseApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWContactSearchService
{
    public class CWContacts : ICWContacts
    {
        public IEnumerable<ContactInfo> FindContacts(FindContactsRequest request)
        {
            var service = new ContactsApi();
            return service.FindContacts(request);
        }
    }
}
