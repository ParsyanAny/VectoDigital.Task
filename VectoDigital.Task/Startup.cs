using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using VectoDigital.Task.ImageHelper;

namespace VectoDigital.Task
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
                services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

                services.AddTransient<IImageHandler, ImageHandler>();
                services.AddTransient<IImageWriter,ImageWriter>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
                if (env.IsDevelopment())
                    app.UseDeveloperExceptionPage();
                else
                    app.UseHsts();

                app.UseStaticFiles();
                app.UseHttpsRedirection();
                app.UseMvc();
        }
    }
}
