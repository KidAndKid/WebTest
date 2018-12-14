using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

[assembly: OwinStartup(typeof(SignalRMvc.ChatHubs.Startup))]
namespace SignalRMvc.ChatHubs
{
    
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
            //服务器的hub注册
        }
    }
}