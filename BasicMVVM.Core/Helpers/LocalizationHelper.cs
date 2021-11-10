using System.Globalization;
using WPFLocalizeExtension.Engine;
using WPFLocalizeExtension.Providers;

namespace BasicMVVM.Core.Helpers
{
    public static class LocalizationHelper
    {
        public static void SetupLanguages()
        {
            ResxLocalizationProvider.Instance.UpdateCultureList("BasicMVVM.Resources", "Strings");
            LocalizeDictionary.Instance.IncludeInvariantCulture = false;
            LocalizeDictionary.Instance.OutputMissingKeys = true;
            LocalizeDictionary.Instance.SetCurrentThreadCulture = true;
            LocalizeDictionary.Instance.Culture = new CultureInfo("en-US");
        }
    }
}
