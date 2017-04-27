using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Owin.Hosting.Demo
{
    public class Startup
    {
        public static void Configuration(IAppBuilder app)
        {
            app.UseStaticFiles();//Path for Static File reading Ex: http://localhost:12345/ReadMe.txt

            app.Use(async (ctx, next) =>
            {
                await ctx.Response.WriteAsync("HelloWorld");
            });
        }
    }
}
