using Kentico.Web.Mvc;

namespace FSdemo
{
    public class ApplicationConfig
    {
        public static void RegisterFeatures(ApplicationBuilder builder)
        {
            builder.UseDataAnnotationsLocalization();
            builder.UseNotFoundHandler();
        }
    }
}
