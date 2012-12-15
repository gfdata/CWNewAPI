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
    }

    public class ApiCredentialsElement : ConfigurationElement
    {
        [ConfigurationProperty("username", IsRequired = true)]
        public String UserName
        {
            get
            {
                return (String)this["username"];
            }
            set
            {
                this["username"] = value;
            }
        }

        [ConfigurationProperty("password", IsRequired = true)]
        public String Password
        {
            get
            {
                return (String)this["password"];
            }
            set
            {
                this["password"] = value;
            }
        }

        [ConfigurationProperty("companyid", IsRequired = true)]
        public String CompanyID
        {
            get
            {
                return (String)this["companyid"];
            }
            set
            {
                this["companyid"] = value;
            }
        }
    }
}
