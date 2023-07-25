using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RHPsicotest.WebSite.Data;
using RHPsicotest.WebSite.Repositories;
using RHPsicotest.WebSite.Repositories.Contracts;
using System;

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
            services.AddScoped<ILoginRepository, LoginRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IPermissionRepository, PermissionRepository>();
            services.AddScoped<IPositionRepository, PositionRepository>();
            services.AddScoped<ICandidateRepository, CandidateRepository>();
            services.AddScoped<IExpedientRepository, ExpedientRepository>();
            services.AddScoped<ITestRepository, TestRepository>();
            //services.AddSingleton<ICompositeViewEngine, CompositeViewEngine>();
            //services.AddSingleton<ITempDataProvider, CookieTempDataProvider>();

            services.AddAuthentication(option =>
            {
                option.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                option.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                option.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            }).AddCookie(option =>
            {
                option.LoginPath = "/Login";
                option.AccessDeniedPath = new PathString("/AccesoDenegado");
                option.ExpireTimeSpan = TimeSpan.FromDays(7);
            });

            services.AddAuthorization(option =>
            {
                option.AddPolicy("Dashboard-Policy", pol => pol.RequireClaim("Permission", new[] { "Dashboard" }));

                // Politicas de Usuario
                option.AddPolicy("List-User-Policy", pol => pol.RequireClaim("Permission", new[] { "Lista-Usuarios" }));
                option.AddPolicy("Create-User-Policy", pol => pol.RequireClaim("Permission", new[] { "Crear-Usuario" }));
                option.AddPolicy("Edit-User-Policy", pol => pol.RequireClaim("Permission", new[] { "Editar-Usuario" }));
                option.AddPolicy("Delete-User-Policy", pol => pol.RequireClaim("Permission", new[] { "Eliminar-Usuario" }));

                //Politicas de Rol
                option.AddPolicy("List-Role-Policy", pol => pol.RequireClaim("Permission", new[] { "Lista-Roles" }));
                option.AddPolicy("Create-Role-Policy", pol => pol.RequireClaim("Permission", new[] { "Crear-Rol" }));
                option.AddPolicy("Edit-Role-Policy", pol => pol.RequireClaim("Permission", new[] { "Editar-Rol" }));
                option.AddPolicy("Delete-Role-Policy", pol => pol.RequireClaim("Permission", new[] { "Eliminar-Rol" }));
                
                //Politicas de Candidato
                option.AddPolicy("List-Candidate-Policy", pol => pol.RequireClaim("Permission", new[] { "Lista-Candidatos" }));
                option.AddPolicy("Create-Candidate-Policy", pol => pol.RequireClaim("Permission", new[] { "Crear-Candidato" }));
                option.AddPolicy("Delete-Candidate-Policy", pol => pol.RequireClaim("Permission", new[] { "Eliminar-Candidato" }));
                option.AddPolicy("Resend-Candidate-Policy", pol => pol.RequireClaim("Permission", new[] { "Reenviar-Correo" }));
                
                //Politicas de Expediente
                option.AddPolicy("List-Expedient-Policy", pol => pol.RequireClaim("Permission", new[] { "Lista-Expedientes" }));
                option.AddPolicy("Edit-Expedient-Policy", pol => pol.RequireClaim("Permission", new[] { "Editar-Expediente" }));
                option.AddPolicy("WatchCurriculums-Expedient-Policy", pol => pol.RequireClaim("Permission", new[] { "Ver-Curriculums" }));
                option.AddPolicy("WatchReports-Expedient-Policy", pol => pol.RequireClaim("Permission", new[] { "Ver-Reportes" }));
                
                //Politicas de Puesto
                option.AddPolicy("List-Position-Policy", pol => pol.RequireClaim("Permission", new[] { "Lista-Puestos" }));
                option.AddPolicy("Create-Position-Policy", pol => pol.RequireClaim("Permission", new[] { "Crear-Puesto" }));
                option.AddPolicy("Edit-Position-Policy", pol => pol.RequireClaim("Permission", new[] { "Editar-Puesto" }));
                option.AddPolicy("Delete-Position-Policy", pol => pol.RequireClaim("Permission", new[] { "Eliminar-Puesto" }));
                
                //Politicas para el candidato
                option.AddPolicy("ConfirmPolicies-Expedient-Policy", pol => pol.RequireClaim("Permission", new[] { "Confirmar-Politicas" }));
                option.AddPolicy("AssignedTests-Test-Policy", pol => pol.RequireClaim("Permission", new[] { "Pruebas-Asignadas" }));
                option.AddPolicy("Create-Expedient-Policy", pol => pol.RequireClaim("Permission", new[] { "Crear-Expediente" }));

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

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Login}/{action=Login}/{id?}");
            });
        }
    }
}
