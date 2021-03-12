using Autofac;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using RestApiModelo.Infrastructure.CrossCutting.IOC;
using RestApiModelo.Infrastructure.Data;
using System;

namespace RestApiModelo.API
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
            var connection = Configuration["SqlConnection:SqlConnectionString"];
            services.AddDbContext<SqlContext>(options => options.UseSqlServer(connection));
            services.AddControllers();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "V1",
                    Title = "RickLocalization - APIs",
                    Description = "Este é um serviço de APIs de teste da Avivatec",
                    Contact = new OpenApiContact
                    {
                        Name = "Renato Marcilio",
                        Email = "sorrisobass@gmail.com",
                        Url = new Uri("https://www.linkedin.com/in/renato-marcilio-ab870a43/"),
                    },
                });
            });

            services.AddSwaggerGen();
        }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule(new ModuleIOC());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger(c =>
            {
                c.SerializeAsV2 = true;
            });

            app.UseSwaggerUI(c =>
            {
#if DEBUG
                // For Debug in Kestrel
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Web API V1");
#else
                // To deploy on IIS
                c.SwaggerEndpoint("/webapi/swagger/v1/swagger.json", "Web API V1");
#endif
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.Run(async context =>
            {
                await context.Response.WriteAsync("Hello, World!");
            });
        }
    }
}
