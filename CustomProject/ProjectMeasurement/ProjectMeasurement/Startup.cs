using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using ProjectMeasurement.Entities;
using ProjectMeasurement.Repository;
using ProjectMeasurement.Services;

namespace ProjectMeasurement
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<MeasurementContext>(options =>
                options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CustomProjectTestAgain;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"));
            services.AddScoped<UserRepository>();
            services.AddScoped<UserService>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
            app.UseStaticFiles();
        }
    }
}
