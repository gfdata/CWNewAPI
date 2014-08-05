using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SD.ConnectwiseApi
{
    public sealed class FindTimeEntriesRequest
    {
        public FindTimeEntriesRequest()
        {
            this.Filters = new List<FilterCriteria<TimeEntryProperties>>();
            this.OrderBy = TimeEntryProperties.StartDate;
            this.Limit = 0;
            this.Skip = 0;
        }
        public List<FilterCriteria<TimeEntryProperties>> Filters { get; set; }

        public TimeEntryProperties OrderBy { get; set; }

        public int Skip { get; set; }

        public int Limit { get; set; }
    }
}
