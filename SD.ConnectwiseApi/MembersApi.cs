using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml;

namespace SD.ConnectwiseApi
{
    public class MembersApi : ServiceBase
    {
        public IEnumerable<MemberInfo> FindMembers(MemberProperties property, string value)
        {
            var message = string.Format(MessageConstants.Members_FindMembers, property, value);
            var doc = new XmlDocument();            
            doc.LoadXml(ProcessAction(message));

            return doc.DocumentElement.ChildNodes.Cast<XmlNode>()
                    .First(q => "Results".Equals(q.Name))
                    .ChildNodes.Cast<XmlNode>()
                    .Select(q => MemberInfo.Create(q));
        }

        public bool ValidateLogin(string username, string password)
        {
            var message = string.Format(MessageConstants.Members_CheckCredentials, username, password);
            var doc = new XmlDocument();
            var responseText = ProcessAction(message);
            doc.LoadXml(responseText);
            var resultNode = doc.DocumentElement.ChildNodes.Cast<XmlNode>()
                            .First(q => "Response".Equals(q.Name))
                            .FirstChild;
            return (resultNode != null && resultNode.InnerText.Equals("Valid"));
        }
    }
}
