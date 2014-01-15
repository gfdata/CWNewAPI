using System;

namespace SD.ConnectwiseApi
{
    internal class MessageConstants
    {
        // Members
        internal static string Members_FindMembers = "<FindMembersAction xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"><CompanyName>[companyId]</CompanyName><IntegrationLoginId>[integratorUsername]</IntegrationLoginId><IntegrationPassword>[integratorPassword]</IntegrationPassword><Conditions>{0} like \"{1}\"</Conditions></FindMembersAction>";
        internal static string Members_CheckCredentials = "<CheckAuthenticationCredentialsAction xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"><IntegrationLoginId>[integratorUsername]</IntegrationLoginId><IntegrationPassword>[integratorPassword]</IntegrationPassword><CompanyName>[companyId]</CompanyName><Request><MemberID>{0}</MemberID><Password>{1}</Password></Request></CheckAuthenticationCredentialsAction>";

        // Services Tickets
        internal static string ServiceTickets_FindTickets = "<FindPartnerTicketsAction xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"><CompanyName>[companyId]</CompanyName><IntegrationLoginId>[integratorUsername]</IntegrationLoginId><IntegrationPassword>[integratorPassword]</IntegrationPassword><Conditions>{0}</Conditions></FindPartnerTicketsAction>";
        internal static string ServiceTickets_GetTicket = "";
        internal static string ServiceTickets_UpdateTickets = "";

    }
}
