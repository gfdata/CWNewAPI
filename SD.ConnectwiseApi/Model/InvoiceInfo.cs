using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace SD.ConnectwiseApi
{
    public sealed class InvoiceInfo
    {
         public string AgreementName { get; set; }
         public string AgreementType { get; set; }
         public string BillingDelivery { get; set; }
         public string BusinessUnit { get; set; }
         public bool Closed { get; set; }
         public string CompanyName { get; set; }
         public bool Email { get; set; }
         public string GlBatchId { get; set; }
         public bool GlPosted { get; set; }
         public int Id { get; set; }
         public DateTime InvoiceDate { get; set; }
         public string InvoiceNumber { get; set; }
         public string InvoiceType { get; set; }
         public string Location { get; set; }
         public string PhaseName { get; set; }
         public string ProjectName { get; set; }
         public string RoutedMemberId { get; set; }
         public string RoutedMemberName { get; set; }
         public string Status { get; set; }
         public string Territory { get; set; }
         public int TicketNumber { get; set; }

        public static InvoiceInfo Create(XmlNode node)
        {
            var item = new InvoiceInfo();

            switch (node.Name)
            {
                //case "SRServiceRecID": item.SRServiceRecID = Convert.ToInt32(node.InnerText); break;
                //case "CompanyName": item.CompanyName = node.InnerText; break;
                //case "ContactName": item.ContactName = node.InnerText; break;
                //case "AddressLine1": item.AddressLine1 = node.InnerText; break;
                //case "AddressLine2": item.AddressLine2 = node.InnerText; break;
                //case "City": item.City = node.InnerText; break;
                //case "StateId": item.StateId = node.InnerText; break;
                //case "Zip": item.Zip = node.InnerText; break;
                //case "Country": item.Country = node.InnerText; break;
                //case "Board": item.Board = node.InnerText; break;
                //case "BoardName": item.BoardName = node.InnerText; break;
                //case "BoardID": item.BoardID = Convert.ToInt32(node.InnerText); break;
                //case "Status": item.TicketStatus = node.InnerText; break;
                //case "StatusName": item.StatusName = node.InnerText; break;
                //case "Priority": item.Priority = node.InnerText; break;
                //case "Location": item.Location = node.InnerText; break;
                //case "Source": item.Source = node.InnerText; break;
                //case "Summary": item.Summary = node.InnerText; break;
                //case "DetailDescription": item.UpdatedBy = node.InnerText; break;
                //case "ClosedFlag": item.ClosedFlag = Convert.ToBoolean(node.InnerText); break;

            }

            return item;
        }
    }
}
