using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Blackboard.Data;
using Microsoft.Extensions.DependencyInjection;
using Blackboard.Models;
using Blackboard.Models.Repositories;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Web.WebPages.Html;

namespace Blackboard
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.ConfigureServices((context, services) =>
                    {
                        // Add your services here
                        services.AddDbContext<ApplicationDbContext>(options =>
                            options.UseSqlServer(
                                context.Configuration.GetConnectionString("DefaultConnection")));

                        services.AddDefaultIdentity<AppUser>(options =>
                            options.SignIn.RequireConfirmedAccount = true)
                            .AddEntityFrameworkStores<ApplicationDbContext>();

                        services.AddSession(options =>
                        {
                            options.IdleTimeout = TimeSpan.FromMinutes(60);
                        });

                        services.AddControllersWithViews();
                        services.AddRazorPages();
                        services.AddScoped<IClassroomRepository, SQLClassroomRepository>();
                        services.AddScoped<IClassroomUserRepository, SQLClassroomUserRepository>();
                        services.AddScoped<IBlackBoardRepository, SQLBlackBoardRepository>();
                        services.AddScoped<IInviteRepository, SQLInviteRepository>();
                        services.AddScoped<IAssignmentRepository, SQLAssignmentRepository>();
                        services.AddScoped<ISubmittedAssignmentRepository, SQLSubmittedAssignmentRepository>();
                        services.AddScoped<ICommentRepository, SQLCommentRepository>();
                    });

                    webBuilder.Configure((context, app) =>
                    {
                        if (context.HostingEnvironment.IsDevelopment())
                        {
                            app.UseDeveloperExceptionPage();
                            app.UseDatabaseErrorPage();
                        }
                        else
                        {
                            app.UseExceptionHandler("/Home/Error");
                            app.UseHsts();
                        }

                        app.UseSession();
                        app.UseHttpsRedirection();
                        app.UseStaticFiles();
                        app.UseRouting();
                        app.UseAuthentication();
                        app.UseAuthorization();

                        app.UseEndpoints(endpoints =>
                        {
                            endpoints.MapControllerRoute(
                                name: "default",
                                pattern: "{controller=Home}/{action=Index}/{id?}");
                            endpoints.MapRazorPages();
                        });
                    });
                });
    }
}