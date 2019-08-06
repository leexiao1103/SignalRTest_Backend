using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Owin;

[assembly: OwinStartup(typeof(SignalRFramework.SignalR.Startup))]

namespace SignalRFramework.SignalR
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //啟動CORS，允許所有
            app.UseCors(CorsOptions.AllowAll);

            //設定SignalR路徑，若要修改預設使用Map()
            app.MapSignalR();
        }
    }
}
