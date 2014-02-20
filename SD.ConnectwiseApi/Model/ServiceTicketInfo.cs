using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace SD.ConnectwiseApi
{
    public sealed class ServiceTicketInfo
    {
        public int SRServiceRecID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string StateId { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string Board { get; set; }
        public string BoardName { get; set; }
        public int BoardID { get; set; }
        public string TicketStatus { get; set; }
        public string StatusName { get; set; }
        public string Priority { get; set; }
        public string Location { get; set; }
        public string Source { get; set; }
        public string Summary { get; set; }
        public string UpdatedBy { get; set; }
        public bool ClosedFlag { get; set; }

        #region Search Fields

        //- SRServiceRecID (number)
        //- CompanyName (text)
        //- ContactName (text)
        //- AddressLine1 (text)
        //- AddressLine2 (text)
        //- City (text)
        //- State (text)
        //- Zip (text)
        //- Country (text)
        //- Board (text)
        //- BoardName (text)
        //- Status (text)
        //- StatusName (text)
        //- ClosedFlag (boolean)
        //- Type (text)
        //- ServiceType (text)
        //- Priority (text)
        //- Location (text)
        //- Source (text)
        //- Summary (text)
        //- DetailDescription (text)
        //- InternalNotes (text)
        //- Resolution (text)
        #endregion

        public static ServiceTicketInfo Create(XmlNode result)
        {
            var item = new ServiceTicketInfo();

            foreach (XmlNode node in result.ChildNodes)
            {
                switch(node.Name) {
                    case "SRServiceRecID": item.SRServiceRecID = Convert.ToInt32(node.InnerText); break;
                    case "CompanyName": item.CompanyName = node.InnerText; break;
                    case "ContactName": item.ContactName = node.InnerText; break;
                    case "AddressLine1": item.AddressLine1 = node.InnerText; break;
                    case "AddressLine2": item.AddressLine2 = node.InnerText; break;
                    case "City": item.City = node.InnerText; break;
                    case "StateId": item.StateId = node.InnerText; break;
                    case "Zip": item.Zip = node.InnerText; break;
                    case "Country": item.Country = node.InnerText; break;
                    case "Board": item.Board = node.InnerText; break;
                    case "BoardName": item.BoardName = node.InnerText; break;
                    case "BoardID": item.BoardID = Convert.ToInt32(node.InnerText); break;
                    case "Status": item.TicketStatus = node.InnerText; break;
                    case "StatusName": item.StatusName = node.InnerText; break;
                    case "Priority": item.Priority = node.InnerText; break;
                    case "Location": item.Location = node.InnerText; break;
                    case "Source": item.Source = node.InnerText; break;
                    case "Summary": item.Summary = node.InnerText; break;
                    case "DetailDescription": item.UpdatedBy = node.InnerText; break;
                    case "ClosedFlag": item.ClosedFlag = Convert.ToBoolean(node.InnerText); break;

                }
                
            }

            
            return item;
        }
    }
}
