using System.Configuration;

namespace Websters.Web.Configuration
{
    /// <summary>
    /// Configuration for a file extension
    /// </summary>
    public class FileExtension : ConfigurationElement
    {
        [ConfigurationProperty("Extension", IsRequired = true)]
        public string Extension
        {
            get { return (string)base["Extension"]; }
            set { base["Extension"] = value.Replace(".", ""); }
        }

        [ConfigurationProperty("ContentType", IsRequired = true)]
        public string ContentType
        {
            get { return (string)base["ContentType"]; }
            set { base["ContentType"] = value; }
        }
    }
}
