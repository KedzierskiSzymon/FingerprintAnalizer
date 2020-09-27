using Common;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOFile.Configurations
{
    public class ApplicationConfiguration : IApplicationConfiguration
    {
        public string ConnectionString 
        { 
            get
            {
                return LoadConfiguration(Sections.FileExtensions);
            }
            set
            {
                SaveConfiguration(Sections.FileExtensions, value);
            }
        }

        public string FingerprintDirectory
        {
            get
            {
                return LoadConfiguration(Sections.FingerprintDirectory);
            }
            set
            {
                SaveConfiguration(Sections.FingerprintDirectory, value);
            }
        }

        public string OperationDirectory
        {
            get
            {
                return LoadConfiguration(Sections.OperationDirectory);
            }
            set
            {
                SaveConfiguration(Sections.OperationDirectory, value);
            }
        }

        public string FileExtension
        {
            get
            {
                return LoadConfiguration(Sections.FileExtensions);
            }
            set
            {
                SaveConfiguration(Sections.FileExtensions, value);
            }
        }

        private string LoadConfiguration(string configurationName)
        {
            Configuration configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            KeyValueConfigurationElement configurationElement = configFile.AppSettings.Settings[configurationName];

            if (configurationElement == null)
                configFile.AppSettings.Settings.Add(configurationName, string.Empty);

            configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);

            return configurationElement.Value;
        }

        public void SaveConfiguration(string configurationName, string value)
        {
            Configuration configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            KeyValueConfigurationElement configurationElement = configFile.AppSettings.Settings[configurationName];

            if (configurationElement == null)
            {
                configFile.AppSettings.Settings.Add(configurationName, value);
            }
            else
            {
                configFile.AppSettings.Settings[configurationName].Value = value;
            }

            configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
        }
    }
}
