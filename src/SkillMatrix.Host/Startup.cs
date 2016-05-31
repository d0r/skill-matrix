using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog;
using NLog.Extensions.Logging;
using SkillMatrix.Business;
using SkillMatrix.Business.Implementation;
using SkillMatrix.Business.Interfaces;
using SkillMatrix.Data.Implementation;
using SkillMatrix.Data.Interfaces;

namespace SkillMatrix
{
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
            
            AutoMapperConfiguratior.Configure();
            
            services.AddSingleton<IMapper, Mapper>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            app.Use((context, next) =>
            {
                if (string.Equals(context.Request.Method, "DEBUG"))
                {
                    return Task.FromResult(0);
                }
                return next();
            });
            
            loggerFactory.AddNLog();
            app.UseMvc();
        }
    }
}
