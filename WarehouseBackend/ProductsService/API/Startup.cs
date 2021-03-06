using API.DependenciesResolvers;
using API.Infrastructure;
using API.Infrastructure.Logging;
using DAL.Contexts;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace API
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; set; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.DalDependenciesResolver(Configuration);
            services.BllDependenciesResolver();
            services.AddSingleton(AutoMapperConfigure.CreateMapper());
            services.AddSingleton<ILog, MyLogger>();

            services.SwaggerConfigure();

            services.AddCors();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, ILog logger)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>()?.CreateScope())
            {
                if (serviceScope != null)
                {
                    var context = serviceScope.ServiceProvider.GetRequiredService<WarehouseContext>();
                    context.Database.Migrate();
                }
            }

            app.ConfigureExceptionHandler(logger);

            app.UseCors(options => options.WithOrigins("http://warehouse:80").AllowAnyMethod().AllowAnyHeader());

            app.UseSwagger(c => { c.SerializeAsV2 = true; });

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "WarehouseAPI");
                c.RoutePrefix = string.Empty;
            });
            
            app.UseHttpsRedirection();
            
            app.UseRouting();
            
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}