using System;
using System.Xml;

namespace SD.ConnectwiseApi
{
    public sealed  class MemberInfo
    {

        public string MemberID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }

        public static MemberInfo Create(XmlNode result)
        {
            var m = new MemberInfo();
            m.MemberID = result["MemberID"].InnerText;
            m.EmailAddress = result["EmailAddress"].InnerText;
            m.FirstName = result["FirstName"].InnerText;
            m.LastName = result["LastName"].InnerText;
            
            //<MemberFindResult>
            //  <MemberID>GFerrie</MemberID>
            //  <EmailAddress>gferrie@somethingdigital.com</EmailAddress>
            //  <FirstName>Glenn</FirstName>
            //  <LastName>Ferrie</LastName>
            //</MemberFindResult>

            return m;
        }
    }
}
