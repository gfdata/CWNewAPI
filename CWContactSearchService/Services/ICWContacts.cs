using SD.ConnectwiseApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CWContactSearchService
{
    public interface ICWContactsChannel: ICWContacts, IClientChannel
    {

    }

    [ServiceContract(Namespace="urn:ps")]
    public interface ICWContacts
    {
        [OperationContract]
        IEnumerable<ContactInfo> FindContacts(string firstname, string lastname, string company);
    }
}
