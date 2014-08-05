using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SD.ConnectwiseApi
{
    public enum TimeEntryProperties
    {
        TimeRecID, // (number) 
        Member, // (text)
        MemberID, // (text)
        StartDate, // (datetime)
        StartTime, // (datetime)
        EndTime, // (datetime)
        HoursActual, // (number)
        HoursInvoiced, // (number)
        HourlyRate, // (number)
        Notes, // (text)
        InternalNotes, // (text)
        SRServiceRecID, // (number)
        WorkRole, // (text)
        WorkType, // (text)
        BillableOption, // (text)
        InvoiceNumber // (text)
    }
}
