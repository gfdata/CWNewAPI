using System.Configuration;

namespace SD.ConnectwiseApi.Config
{
    public class LoggingElement : ConfigurationElement
    {
        [ConfigurationProperty("sourcename", IsRequired = false)]
        public string SourceName
        {
            get
            {
                return (string)this["sourcename"];
            }
            set
            {
                this["sourcename"] = value;
            }
        }
    }
}