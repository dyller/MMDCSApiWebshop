using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using TicketShopApp.Core.ApplicationService;
using TicketShopApp.Core.ApplicationService.Service;
using TicketShopApp.Core.DomainService;
using Webshop.Infrastructure.FakeRepository;

namespace WebShopSpacesAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            _conf = configuration;
            FAKEDB.InitData();

        }
        //public Startup(IHostingEnvironment env)
        //{

        //    _env = env;
        //    var builder = new ConfigurationBuilder()
        //        .SetBasePath(env.ContentRootPath)
        //        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
        //        .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
        //        .AddEnvironmentVariables();
        //    _conf = builder.Build();


        //}
        //public IHostingEnvironment _env { get; set; }
        public IConfiguration _conf { get; }


        public void ConfigureServices(IServiceCollection services)
        {
            /*services.AddDbContext<CustomerAppContext>(
                opt => opt.UseInMemoryDatabase("ThaDB")
                );*/

            //if (_env.IsDevelopment())
            //{
            //    services.AddDbContext<PetShopAppContext>(
            //        opt => opt.UseSqlite("Data Source=customerApp.db"));
            //}
            //else if (_env.IsProduction())
            //{
            //    services.AddDbContext<PetShopAppContext>(
            //        opt => opt
            //            .UseSqlServer(_conf.GetConnectionString("DefaultConnection")));
            //}

            services.AddScoped<ITicketRepository, TicketRepository>();
            services.AddScoped<ITicketService, TicketService>();

            //services.AddScoped<IPetRepository1, SQLPetRepository>();
            //services.AddScoped<IPetService, PetService>();

            services.AddMvc().AddJsonOptions(options => {
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            //app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
