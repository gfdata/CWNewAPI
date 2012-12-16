using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SD.ConnectwiseApi.Model;
using System.Xml.Linq;

namespace SD.ConnectwiseApi
{
    public class MembersApi : IDisposable
    {
        private readonly ServiceWrapper svc;
        public MembersApi()
        {
            svc = new ServiceWrapper();
        }
        public IEnumerable<MemberInfo> FindMembers(MemberProperties property, string value)
        {
            var message = string.Format(MessageConstants.MembersFindMembers, property, value);
            // TODO: Members: Define result type for Member data.
            var response = svc.ProcessAction(message);
            var doc = XDocument.Parse(response, LoadOptions.None);
            var results = doc.Descendants(XName.Get("MemberFindResult"));
            foreach (var item in results)
            {
                var member = new MemberInfo();
                member.EmailAddress = item.Element(XName.Get("EmailAddress")).Value;
                member.FirstName = item.Element(XName.Get("FirstName")).Value;
                member.LastName = item.Element(XName.Get("LastName")).Value;
                //member.EmailAddress = item.Element(XName.Get("EmailAddress")).Value;
                yield return member;
            }
        }

        public void Dispose()
        {
            
        }
    }

    /// <summary>
    /// Find members search properties
    /// </summary>
    public enum MemberProperties
    {
        MemberID,
        EmailAddress,
        FirstName,
        LastName
    }
}
