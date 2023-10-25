using AspNetCoreHero.ToastNotification;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Threading;
using System.Threading.Tasks;
using WEBBANTBDTK.Models;

namespace WEBBANTBDTK
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var Stringconnectdb = Configuration.GetConnectionString("dbWebbantbdtk");
            services.AddDbContext<dbWEBTBDTKContext>(options => options.UseSqlServer(Stringconnectdb));

            services.AddSingleton<HtmlEncoder>(HtmlEncoder.Create(allowedRanges: new[] { UnicodeRanges.All }));

            services.AddSession();
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(p =>
                {
                    p.Cookie.Name = "UserLoginCookie";
                    p.ExpireTimeSpan = TimeSpan.FromDays(1);
                    //p.LoginPath = "/dang-nhap.html";
                                  
                    //p.LogoutPath = "/dang-xuat/html";
                    p.AccessDeniedPath = "/not-found.html";

                    


                });


            services.AddControllersWithViews().AddRazorRuntimeCompilation();

            services.AddNotyf(config =>
            {
                config.DurationInSeconds = 3;
                config.IsDismissable = true;
                config.Position = NotyfPosition.TopRight;
            });


            //services.AddAuthentication()
            //    .AddGoogle(googleOptions =>
            //    {
            //        // Đọc thông tin Authentication:Google từ appsettings.json
            //        IConfigurationSection googleAuthNSection = Configuration.GetSection("Authentication:Google");

            //        // Thiết lập ClientID và ClientSecret để truy cập API google
            //        googleOptions.ClientId = googleAuthNSection["ClientId"];
            //        googleOptions.ClientSecret = googleAuthNSection["ClientSecret"];

            //    }).AddFacebook(facebookOptions =>
            //    {
            //        // Đọc cấu hình
            //        IConfigurationSection facebookAuthNSection = Configuration.GetSection("Authentication:Facebook");
            //        facebookOptions.AppId = facebookAuthNSection["AppId"];
            //        facebookOptions.AppSecret = facebookAuthNSection["AppSecret"];
            //        // Thiết lập đường dẫn Facebook chuyển hướng đến
            //        facebookOptions.CallbackPath = "/sigin-facbook";
            //    });


            //services.Configure<VNPAYConfig>(Configuration.GetSection("VNPAYConfig"));


            services.AddControllersWithViews();
            services.AddRazorPages();
            services.AddHttpContextAccessor();
            services.AddSingleton<IConfiguration>(Configuration);


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
        

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                 name: "areas",
                 pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
               );
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

            });


           
        }
    }
}
