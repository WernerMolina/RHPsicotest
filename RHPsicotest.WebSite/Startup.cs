using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RHPsicotest.WebSite.Data;
using RHPsicotest.WebSite.Repositories;
using RHPsicotest.WebSite.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RHPsicotest.WebSite
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
            services.AddControllersWithViews();

            services.AddDbContextPool<RHPsicotestDbContext>(option => option.UseSqlServer(Configuration.GetConnectionString("RHPsicotestConnection")));

            services.AddScoped<DbContext, RHPsicotestDbContext>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IPermissionRepository, PermissionRepository>();
            services.AddScoped<IStallRepository, StallRepository>();
            services.AddScoped<IEmailUserRepository, EmailUserRepository>();

            //services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            //.AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, option =>
            //{
            //    option.AccessDeniedPath = "/Home/Index";
            //    option.LoginPath = "/User/Login";
            //});

            //services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(option =>
            //{
            //    option.LoginPath = new PathString("/Home/Index");
            //});

            services.AddAuthentication(option =>
            {
                option.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                option.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                option.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            }).AddCookie(option =>
            {
                option.LoginPath = "/Login";
            });

            services.AddAuthorization(option =>
            {
                // Politicas de Usuario
                option.AddPolicy("List-Users-Policy", pol => pol.RequireClaim("Permission", new[] {"Lista-Usuarios"}));
                option.AddPolicy("Create-User-Policy", pol => pol.RequireClaim("Permission", new[] { "Crear-Usuario" }));
                option.AddPolicy("Edit-User-Policy", pol => pol.RequireClaim("Permission", new[] { "Editar-Usuario" }));
                option.AddPolicy("Delete-User-Policy", pol => pol.RequireClaim("Permission", new[] { "Eliminar-Usuario" }));
                
                //Politicas de Rol
                option.AddPolicy("List-Roles-Policy", pol => pol.RequireClaim("Permission", new[] { "Lista-Roles" }));
                option.AddPolicy("Create-Role-Policy", pol => pol.RequireClaim("Permission", new[] { "Crear-Rol" }));
                option.AddPolicy("Edit-Role-Policy", pol => pol.RequireClaim("Permission", new[] { "Editar-Rol" }));
                option.AddPolicy("Delete-Role-Policy", pol => pol.RequireClaim("Permission", new[] { "Eliminar-Rol" }));

            });
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

            app.UseRouting();

            app.UseAuthorization();
            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
