using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace SD.ConnectwiseApi.Config
{
    public class ConnectwiseConfigSection : ConfigurationSection
    {
        [ConfigurationProperty("apicredentials", IsRequired=true)]
        public ApiCredentialsElement ApiCredentials
        {
            get { return (ApiCredentialsElement)this["apicredentials"]; }
            set { this["apicredentials"] = value; }
        }

        [ConfigurationProperty("logging", IsRequired=false)]
        public LoggingElement Logging
        {
            get { return (LoggingElement)this["logging"]; }
            set { this["logging"] = value; }
        }
    }
}
