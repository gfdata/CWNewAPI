using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SD.ConnectwiseApi
{
    public sealed class FindInvoiceRequest
    {
        public FindInvoiceRequest()
        {
            this.Filters = new List<FilterCriteria<InvoiceProperties>>();
            this.OrderBy = InvoiceProperties.InvoiceNumber;
            this.Limit = 0;
            this.Skip = 0;
        }
        public List<FilterCriteria<InvoiceProperties>> Filters { get; set; }

        public InvoiceProperties OrderBy { get; set; }

        public int Skip { get; set; }

        public int Limit { get; set; }
    }
}
