using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProvaTodos.Application;
using ProvaTodos.Application.Interfaces;
using ProvaTodos.Domain.Interfaces;
using ProvaTodos.Infrastructure;
using ProvaTodos.Infrastructure.Repository;

namespace ProvaTodos.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddScoped<IConfiguration>(i => Configuration);
            services.AddScoped<IDefaultContextOptions, DefaultContextOptions>();
            services.AddScoped<Context>();
            // services.AddScoped<IContext, Context>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IAccountService, AccountService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());   

            app.UseMvc();
        }
    }
}
