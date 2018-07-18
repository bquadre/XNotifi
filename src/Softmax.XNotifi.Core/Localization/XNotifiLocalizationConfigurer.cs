using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Softmax.XNotifi.Localization
{
    public static class XNotifiLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(XNotifiConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(XNotifiLocalizationConfigurer).GetAssembly(),
                        "Softmax.XNotifi.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
