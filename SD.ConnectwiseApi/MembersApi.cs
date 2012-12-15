using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SD.ConnectwiseApi
{
    public class MembersApi : IDisposable
    {
        private readonly ServiceWrapper svc;
        public MembersApi()
        {
            svc = new ServiceWrapper();
        }
        public object FindMembers(MemberProperties property, string value)
        {
            var message = string.Format(MessageConstants.MembersFindMembers, property, value);
            // TODO: Members: Define result type for Member data.
            return svc.ProcessAction(message);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
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
