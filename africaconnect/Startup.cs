using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.HttpOverrides;
using System.Net;

namespace africaconnect
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => false;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddSession();
            services.AddSingleton<IActionContextAccessor, ActionContextAccessor>(); // <= Add this for pagination
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
          

        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            


            app.UseHttpsRedirection();
            app.UseCookiePolicy();
            app.UseStaticFiles();
            app.UseSession();
            app.UseMvc();

           
            /*app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
            });*/

            app.UseAuthentication();

            app.Run(async (context) =>
            {
                 await context.Response.WriteAsync("<script>window.location='/Home/error404'</script>");
                //await context.Response.Redirect("");
            });


        }
    }
}
