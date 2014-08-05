using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace SD.ConnectwiseApi
{
    public sealed class TimeEntryInfo
    {
        public static TimeEntryInfo Create(XmlNode result)
        {
            var item = new TimeEntryInfo();

            foreach (XmlNode node in result.ChildNodes)
            {
                switch (node.Name)
                {
                    case "TimeRecID": item.TimeRecID = node.InnerText.ToInt32(); break; // <TimeRecID>47301</TimeRecID>
                    case "Member": item.Member = node.InnerText; break; // <Member>Glenn Ferrie</Member>
                    case "MemberID": item.MemberID = node.InnerText; break; // <MemberID>GFerrie</MemberID>
                    case "StartDate": item.StartDate = node.InnerText.ToNullableDateTime(); break; // <StartDate>2012-02-01T00:00:00</StartDate>
                    case "StartTime": item.StartTime = node.InnerText.ToNullableDateTime(); break; // <StartTime xsi:nil="true" />
                    case "EndTime": item.EndTime = node.InnerText.ToNullableDateTime(); break; // <EndTime xsi:nil="true" />
                    case "HoursActual": item.HoursActual = node.InnerText.ToDecimal(); break; // <HoursActual>2.00</HoursActual>
                    case "HoursInvoiced": item.HoursInvoiced = node.InnerText.ToDecimal(); break; // <HoursInvoiced>2.00</HoursInvoiced>
                    case "HourslyRate": item.HourslyRate = node.InnerText.ToDecimal(); break; // <HourlyRate>175.0000</HourlyRate>
                    case "Notes": item.Notes = node.InnerText; break; // <Notes>Call with Lakeisha and team for a walk-though of intranet applications</Notes>
                    case "SRServiceRecID": item.SRServiceRecID = node.InnerText.ToNullableInt32(); break; // <SRServiceRecID>19356</SRServiceRecID>
                    case "WorkRole": item.WorkRole = node.InnerText; break; // <WorkRole>Senior Programmer</WorkRole>
                    case "WorkType": item.WorkType = node.InnerText; break; // <WorkType>SD Office</WorkType>
                    case "BillableOption": item.BillableOption = node.InnerText; break; // <BillableOption>B</BillableOption>
                    case "InvoiceNumber": item.InvoiceNumber = node.InnerText; break; // <InvoiceNumber>10019</InvoiceNumber>
    
                    default:
                        break;
                }
            }

            return item;
        }

        public int TimeRecID { get; set; }

        public string InvoiceNumber { get; set; }

        public string BillableOption { get; set; }

        public string WorkType { get; set; }

        public string WorkRole { get; set; }

        public int? SRServiceRecID { get; set; }

        public string Notes { get; set; }

        public decimal HoursActual { get; set; }

        public decimal HoursInvoiced { get; set; }

        public decimal HourslyRate { get; set; }

        public string Member { get; set; }

        public string MemberID { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        public string TicketCompanyName { get; set; }

        public string TicketSummary { get; set; }
    }
}
