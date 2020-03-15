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
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using WebApplication4.Data;

namespace WebApplication4
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

            services.AddDbContext<HaandvaerkerContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("WebApplication4Context")));

            //    Cycles in Domaine model
            //    https://stackoverflow.com/questions/58846765/cycle-in-database
            //https://stackoverflow.com/questions/55787018/net-core-3-preview-4-addnewtonsoftjson-is-not-defined
            services.AddControllers().AddNewtonsoftJson(x => x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            //services.AddDbContext<F20ITONKASPNETCore31MicroserviceBackendContext>(options =>
            //        options.UseSqlServer(Configuration.GetConnectionString("F20ITONKASPNETCore31MicroserviceBackendContext")));
            services.AddDbContext<HaandvaerkerContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("F20ITONKASPNETDockerConnection")));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, HaandvaerkerContext db)
        {
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

            using var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope();
            var context = serviceScope.ServiceProvider.GetRequiredService<HaandvaerkerContext>();
            //context.Database.EnsureCreated();
            db.Database.Migrate();
        }
    }
}
