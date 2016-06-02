using Autofac;
using System;
using System.Web.Http;

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