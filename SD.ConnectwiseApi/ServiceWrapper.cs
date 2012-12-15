using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SD.ConnectwiseApi.Config;
using System.Configuration;

namespace SD.ConnectwiseApi
{
    public class ServiceWrapper : IDisposable
    {
        private CWApi.integration_io client;
        private ConnectwiseConfigSection config;
        public ServiceWrapper()
        {
            client = new CWApi.integration_io();
            config = (ConnectwiseConfigSection)ConfigurationManager.GetSection("connectwise");

        }

        public string ProcessAction(string actionXml)
        {
            var request = AddAuthCredentials(actionXml);
            return client.ProcessClientAction(request);   
        }

        private string AddAuthCredentials(string message)
        {
            if (string.IsNullOrWhiteSpace(message)) throw new ArgumentNullException("message");
            message = message.Replace("[integratorUsername]", config.ApiCredentials.UserName);
            message = message.Replace("[integratorPassword]", config.ApiCredentials.Password);
            message = message.Replace("[companyId]", config.ApiCredentials.CompanyID);
            return message;
        }

        private bool _disposed = false;
        public void Dispose()
        {
            if (!_disposed)
            {
                _disposed = true;
                client = null;
            }
        }
    }
}
