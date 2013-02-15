using System;

namespace SD.ConnectwiseApi
{
    internal class MessageConstants
    {
        internal static string MembersFindMembers = "<?xml version=\"1.0\" encoding=\"utf-16\"?><FindMembersAction xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"><IntegrationLoginId>[integratorUsername]</IntegrationLoginId><IntegrationPassword>[integratorPassword]</IntegrationPassword><CompanyName>[companyId]</CompanyName><Filter xsi:type=\"QueryLikeExpression\"><Left xsi:type=\"QueryPropertyExpression\"><Name>{0}</Name></Left><Right xsi:type=\"QueryConstantExpression\"><ValueType>System.String</ValueType><Value xsi:type=\"xsd:string\">{1}</Value></Right></Filter></FindMembersAction>";
        internal static string MembersCheckCredentials = "<CheckAuthenticationCredentialsAction xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"><IntegrationLoginId>[integratorUsername]</IntegrationLoginId><IntegrationPassword>[integratorPassword]</IntegrationPassword><CompanyName>[companyId]</CompanyName><Request><MemberID>{0}</MemberID><Password>{1}</Password></Request></CheckAuthenticationCredentialsAction>"; 
    }
}
