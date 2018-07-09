using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MockSystem.Data;

namespace MockSystem
{
    public class Startup
    {
        //this is the intry point to configuration data
        private IConfigurationRoot _configurationRoot;

        //this give me infomation about hosting inveronment
        public Startup(IHostingEnvironment hostingEnvironment)
        {
            _configurationRoot = new ConfigurationBuilder().SetBasePath(hostingEnvironment.ContentRootPath).AddJsonFile("appsettings.json").Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
        
            //register database to services
            services.AddDbContext<DataContext>(options => options.UseMySql("Server=localhost;Database=Hospital;User=root;Password=mgiba;"));
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env , ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();
            //used to run the exception during the development mode
            app.UseDeveloperExceptionPage();
            //Used to show error pages for HTTP status code
            app.UseStatusCodePages();
            //Used to add static data such as custom CSS or images
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}
