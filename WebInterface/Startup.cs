﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebInterface.Startup))]
namespace WebInterface
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
			ConfigureDIContainer(app);
            ConfigureAuth(app);	
        }
    }
}
