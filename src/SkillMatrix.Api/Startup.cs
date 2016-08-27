using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using SkillMatrix.Business.Infrastructure;
using SkillMatrix.Business.Services.Contracts;
using SkillMatrix.Business.Services.Implementations;
using SkillMatrix.Data;
using SkillMatrix.Data.Services.Contracts;
using SkillMatrix.Data.Services.Implementations;
using System.Threading.Tasks;

namespace SkillMatrix.Api
{
    //public class Startup
    //{
    //    // This method gets called by the runtime. Use this method to add services to the container.
    //    // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
    //    public void ConfigureServices(IServiceCollection services)
    //    {
    //    }

    //    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    //    public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
    //    {
    //        loggerFactory.AddConsole();

    //        if (env.IsDevelopment())
    //        {
    //            app.UseDeveloperExceptionPage();
    //        }

    //        app.Run(async (context) =>
    //        {
    //            await context.Response.WriteAsync("Hello World!");
    //        });
    //    }
    //}

    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc();

            services.AddScoped<ISkillService, SkillService>();
            services.AddScoped<ISkillRepository, SkillRepository>();
            services.AddScoped((_) => new SkillMatrixContext(Configuration.GetConnectionString("SkillMatrix")));
            AutoMapperConfigurator.Configure();
            services.AddSingleton<IMapper, Mapper>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddNLog();

            env.ConfigureNLog("nlog.config");

            app.Use((context, next) =>
            {
                if (string.Equals(context.Request.Method, "DEBUG"))
                {
                    return Task.FromResult(0);
                }
                return next();
            });

            app.UseMvc();
        }
    }
}
