using Localize.Application.Interfaces;
using Localize.Application.Services;
using Localize.Domain.Interfaces;
using Localize.Infra.Sql.Repositories;
using Localize.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Data;
using System.Data.SqlClient;

namespace Localize
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
            services.AddControllers();

            services.AddTransient<IFilmeService, FilmeService>();
            services.AddTransient<IFilmeRepository, FilmeRepository>();

            services.AddTransient<IClienteService, ClienteService>();
            services.AddTransient<IClienteRepository, ClienteRepository>();

            services.AddTransient<ILocadorService, LocadorService>();
            services.AddTransient<ILocadorRepository, LocadorRepository>();

            services.AddSingleton<IDbConnection>(x =>
            {
                return new SqlConnection(Configuration.GetConnectionString("Default"));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
