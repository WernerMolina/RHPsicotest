using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.CodeAnalysis.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RHPsicotest.WebSite.Data;
using RHPsicotest.WebSite.Repositories;
using RHPsicotest.WebSite.Repositories.Contracts;
using System;
using System.IO;

namespace RHPsicotest.WebSite
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment environment)
        {
            Configuration = configuration;
            Environment = environment;
        }

        public IConfiguration Configuration { get; }

        public IWebHostEnvironment Environment { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddRazorPages().AddRazorRuntimeCompilation();

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

            //services.AddAntiforgery(option =>
            //{
            //    option.Cookie.Name = "AntiforgeryCookieRHPsicotest";
            //    option.FormFieldName = "AntiforgeryFieldName";
            //    option.HeaderName = "AntiforgeryHeaderRHPsicotest";
            //    option.Cookie.MaxAge = TimeSpan.FromHours(5);
            //    option.Cookie.Expiration = TimeSpan.FromHours(5);
            //});

            //services.AddAuthentication(option =>
            //{
            //    option.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            //    option.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            //    option.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            //}).AddCookie(option =>
            //{
            //    option.Cookie.Name = "RHPsicotest";
            //    option.Cookie.MaxAge = TimeSpan.FromDays(7);

            //    option.LoginPath = "/Login";
            //    option.AccessDeniedPath = new PathString("/AccesoDenegado");
            //    option.ExpireTimeSpan = TimeSpan.FromDays(7);
            //});
            
            var keysFolder = Path.Combine(Environment.ContentRootPath, "Keys");

            services.AddDataProtection()
                    .PersistKeysToFileSystem(new DirectoryInfo(keysFolder))
                    .SetApplicationName("MyWebsite")
                    .SetDefaultKeyLifetime(TimeSpan.FromDays(90));

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                    .AddCookie(options =>
                    {
                        options.Cookie.Name = "RHPsicotest";
                        options.Cookie.MaxAge = TimeSpan.FromDays(7);
                        
                        options.LoginPath = "/Login"; 
                        options.AccessDeniedPath = new PathString("/AccesoDenegado");

                        options.ExpireTimeSpan = TimeSpan.FromDays(7);

                        options.SlidingExpiration = true; 
                        options.Cookie.IsEssential = true;
                    });

            //services.AddDataProtection()
            //        .PersistKeysToFileSystem(new DirectoryInfo("SOME WHERE IN STORAGE"))
            //        //.ProtectKeysWithCertificate(new X509Certificate2());
            //        .SetDefaultKeyLifetime(TimeSpan.FromDays(90));


            //var keysFolder = Path.Combine(_environment.ContentRootPath, "Keys");
            //services.AddDataProtection()
            //    .PersistKeysToFileSystem(new DirectoryInfo(keysFolder))
            //    .SetApplicationName("MyWebsite")
            //    .SetDefaultKeyLifetime(TimeSpan.FromDays(90));

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
