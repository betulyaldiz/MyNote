using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(MyNoteAPI.Startup))]

namespace MyNoteAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //bu satırtüm sitelere response izin verir
            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);
            ConfigureAuth(app);
        }
    }
}
