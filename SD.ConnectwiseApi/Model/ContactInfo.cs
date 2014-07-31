using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;

namespace SD.ConnectwiseApi
{
    [DataContract]
    public sealed class ContactInfo
    {
        public static ContactInfo Create(XmlNode result)
        {
            var item = new ContactInfo();

            foreach (XmlNode node in result.ChildNodes)
            {
                switch (node.Name)
                {
                    case "FirstName": item.FirstName = node.InnerText; break; // <FirstName>Matthew</FirstName>
                    case "LastName": item.LastName = node.InnerText; break;// <LastName>Castagne</LastName>
                    case "CompanyName": item.CompanyName = node.InnerText; break;// <CompanyName>WTAS</CompanyName>
                    case "CompanyRecID": item.CompanyRecID = Convert.ToInt32(node.InnerText); break;// <CompanyRecID>1522</CompanyRecID>
                    case "Phone": item.Phone = node.InnerText; break;// <Phone>6462135116</Phone>
                    case "Email": item.Email = node.InnerText; break;// <Email>matthew.castagne@wtas.com</Email>
                    case "Type": item.ContactType = node.InnerText; break;// <Type>Approver</Type>
                    case "DefaultFlag": item.DefaultFlag = node.InnerText; break;// <DefaultFlag>true</DefaultFlag>
                    case "AddressLine1": item.AddressLine1 = node.InnerText; break;// <AddressLine1>1177 Avenue of the Americas</AddressLine1>
                    case "AddressLine2": item.AddressLine2 = node.InnerText; break;// <AddressLine2>18th  Floor</AddressLine2>
                    case "City": item.City = node.InnerText; break;// <City>New York</City>
                    case "State": item.State = node.InnerText; break;// <State>NY</State>
                    case "Zip": item.Zip = node.InnerText; break;// <Zip>10036</Zip>
                    case "Country": item.Country = node.InnerText; break;// <Country>United States</Country>

                    case "ContactRecID": item.ContactRecID = Convert.ToInt32(node.InnerText); break;// <ContactRecID>2091</ContactRecID>
                    case "Id": item.Id = Convert.ToInt32(node.InnerText); break;// <Id>2091</Id>
                }

            }

            return item;
        }

        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string CompanyName { get; set; }
        [DataMember]
        public int CompanyRecID { get; set; }
        [DataMember]
        public string Phone { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string ContactType { get; set; }
        [DataMember]
        public string DefaultFlag { get; set; }
        [DataMember]
        public string AddressLine1 { get; set; }
        [DataMember]
        public string AddressLine2 { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public string State { get; set; }
        [DataMember]
        public string Zip { get; set; }
        [DataMember]
        public string Country { get; set; }
        [DataMember]
        public int ContactRecID { get; set; }
    }
}
