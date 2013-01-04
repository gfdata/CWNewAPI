using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SD.ConnectwiseApi.Model;
using System.Xml.Linq;
using System.Xml;

namespace SD.ConnectwiseApi
{
    public class MembersApi : ServiceWrapper
    {
        public IEnumerable<MemberInfo> FindMembers(MemberProperties property, string value)
        {
            var message = string.Format(MessageConstants.MembersFindMembers, property, value);
            var doc = new XmlDocument();            
            doc.LoadXml(ProcessAction(message));
            return doc.DocumentElement.ChildNodes.Cast<XmlNode>()
                    .First(q => "Results".Equals(q.Name))
                    .ChildNodes.Cast<XmlNode>()
                    .Select(q => MemberInfo.Create(q));
        }
    }
}
