using SD.ConnectwiseApi.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SD.ConnectwiseApi.Model
{
    public sealed class FindServiceTicketRequest
    {
        public FindServiceTicketRequest()
        {
            this.Filters = new List<FilterCriteria<ServiceTicketProperties>>();
            this.OrderBy = ServiceTicketProperties.CompanyName;
            this.Limit = 0;
            this.Skip = 0;
        }
        public List<FilterCriteria<ServiceTicketProperties>> Filters { get; set; }

        public ServiceTicketProperties OrderBy { get; set; }

        public int Skip { get; set; }

        public int Limit { get; set; }
    }
}
