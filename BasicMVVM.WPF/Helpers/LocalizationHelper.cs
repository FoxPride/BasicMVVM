using System.Globalization;
using BasicMVVM.Resources;
using BasicMVVM.Resources.Strings;
using WPFLocalizeExtension.Engine;
using WPFLocalizeExtension.Providers;

namespace BasicMVVM.WPF.Helpers
{
    /// <summary>
    ///     A helper <see langword="class" /> for UI language setup.
    /// </summary>
    public static class LocalizationHelper
    {
        /// <summary>
        ///     Loads culture list from resources and sets app language.
        /// </summary>
        public static void LoadLanguages()
        {
            var resources = typeof(ResourcesMain).Namespace;

            ResxLocalizationProvider.Instance.UpdateCultureList(resources, "Strings");
            LocalizeDictionary.Instance.IncludeInvariantCulture = false;
            LocalizeDictionary.Instance.OutputMissingKeys = true;

            SetAppLanguage(CultureInfo.CurrentUICulture);
        }

        /// <summary>
        ///     Sets UI app language according to passed culture parameter.
        /// </summary>
        /// <param name="currentCulture">
        ///     Culture to look for in merged cultures from resources.
        /// </param>
        private static void SetAppLanguage(CultureInfo currentCulture)
        {
            var cultureList = LocalizeDictionary.Instance.MergedAvailableCultures;
            if (cultureList.Contains(currentCulture))
            {
                LocalizeDictionary.Instance.Culture = currentCulture;
                Strings.Culture = currentCulture;
            }
            else if (cultureList.Contains(currentCulture.Parent))
            {
                LocalizeDictionary.Instance.Culture = currentCulture.Parent;
                Strings.Culture = currentCulture.Parent;
            }
            else
            {
                var culture = new CultureInfo("en-US");
                LocalizeDictionary.Instance.Culture = culture;
                Strings.Culture = culture;
            }
        }
    }
}
