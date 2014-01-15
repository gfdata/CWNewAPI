using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace SD.ConnectwiseApi.Model
{
    public sealed class ServiceTicketInfo
    {
        public int SRServiceRecID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string Board { get; set; }
        public string BoardName { get; set; }
        public string Status { get; set; }
        public string StatusName { get; set; }
        public string Type { get; set; }
        public string ServiceType { get; set; }
        public string Priority { get; set; }
        public string Location { get; set; }
        public string Source { get; set; }
        public string Summary { get; set; }
        public string DetailDescription { get; set; }
        public string InternalNotes { get; set; }
        public string Resolution { get; set; }
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
            
            return item;
        }
    }
}
