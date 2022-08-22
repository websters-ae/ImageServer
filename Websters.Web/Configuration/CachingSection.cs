using System;
using System.Configuration;

namespace Websters.Web.Configuration
{
    public class CachingSection : ConfigurationSection
    {
        [ConfigurationProperty("CachingTimeSpan", IsRequired = true)]
        public TimeSpan CachingTimeSpan
        {
            get { return (TimeSpan)base["CachingTimeSpan"]; }
            set { base["CachingTimeSpan"] = value; }
        }

        [ConfigurationProperty("FileExtensions", IsDefaultCollection = true,
          IsRequired = true)]
        public FileExtensionCollection FileExtensions
        {
            get { return ((FileExtensionCollection)base["FileExtensions"]); }
        }
    }
}
