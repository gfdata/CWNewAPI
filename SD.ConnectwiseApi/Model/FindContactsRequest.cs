using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SD.ConnectwiseApi
{
    public class FindContactsRequest
    {
        public FindContactsRequest()
        {
            this.Filters = new List<FilterCriteria<ContactProperties>>();
            this.OrderBy = ContactProperties.LastName;
            this.Limit = 0;
            this.Skip = 0;
        }
        public List<FilterCriteria<ContactProperties>> Filters { get; set; }

        public ContactProperties OrderBy { get; set; }

        public int Skip { get; set; }

        public int Limit { get; set; }
    }
}
