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
        public IEnumerable<ContactInfo> FindContacts(string firstname, string lastname, string company)
        {
            var request = new FindContactsRequest();

            if (!string.IsNullOrWhiteSpace(firstname))
            {
                request.Filters.Add(new FilterCriteria<ContactProperties> { Operation = FilterOperation.Like, TargetField = ContactProperties.FirstName, Value = firstname });
            }

            if (!string.IsNullOrWhiteSpace(lastname))
            {
                request.Filters.Add(new FilterCriteria<ContactProperties> { Operation = FilterOperation.Like, TargetField = ContactProperties.LastName, Value = lastname });
            }

            if (!string.IsNullOrWhiteSpace(company))
            {
                request.Filters.Add(new FilterCriteria<ContactProperties> { Operation = FilterOperation.Like, TargetField = ContactProperties.CompanyName, Value = company });
            }
            var service = new ContactsApi();
            return service.FindContacts(request);
        }
    }
}
