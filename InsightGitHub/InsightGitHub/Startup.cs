using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(InsightGitHub.Startup))]

namespace InsightGitHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            // Making some changes on code in Master
            // This line is edited by  sohan's account
            // This line is edited by  deepak's account
        }
    }
}
