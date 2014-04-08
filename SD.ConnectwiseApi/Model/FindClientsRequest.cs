using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SD.ConnectwiseApi;

namespace SD.ConnectwiseApi
{
    public sealed class FindClientsRequest
    {
        public List<FilterCriteria<ClientProperties>> Filters { get; set; }

        public InvoiceProperties OrderBy { get; set; }

        public int Skip { get; set; }

        public int Limit { get; set; }
    }
}
