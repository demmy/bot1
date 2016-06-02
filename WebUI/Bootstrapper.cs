using System.Web.Http;
using Autofac;

namespace WebUI
{
    internal static class Bootstrapper
    {
        internal static void Run()
        {
            SetAutofacWebAPI();
        }

        private static void SetAutofacWebAPI()
        {
            var configuration = GlobalConfiguration.Configuration;
            var builder = new ContainerBuilder();
            //builder.ConfigureWebApi(configuration);
        }
    }
}