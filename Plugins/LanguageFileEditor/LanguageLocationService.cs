using System.Configuration;
using System.Linq;
using System.Web;
using EPiServer.Find.Helpers.Text;

namespace EPiServer.Plugins.LanguageFileEditor
{
    public static class LanguageLocationService
    {
        /// <summary>
        /// Get the first language path set in EPiServerFramework.config.
        /// 
        /// TODO: implement support for multiple paths
        /// </summary>
        public static string LanguagePath()
        {
            var providers = EPiServer.Framework.Configuration.EPiServerFrameworkSection.Instance.Localization.Providers;
            var path = providers.Cast<ProviderSettings>()
                .Select(settings => settings.Parameters)
                .Select(parameters => parameters.Get("virtualPath"))
                .FirstOrDefault(vp => !vp.IsNullOrEmpty());

            return HttpContext.Current.Server.MapPath(path);
        }
    }
}
