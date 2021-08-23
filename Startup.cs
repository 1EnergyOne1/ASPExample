using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ASPExample
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts(); // использование механизма дополнительного усовершенствования безопасности
            }

            app.UseRouting();
            app.UseHttpsRedirection(); // перенаправление с HTTP в HTTPS

            app.UseDefaultFiles(); //index.html, default.html.... // выполняется перед USeStaticFiles, в ином случае не сработает
            app.UseStaticFiles(); // использовать статические файлы

            app.UseEndpoints(endpoints =>
            {
                //  endpoints.MapGet("/", async context =>   // оператор направляет любой запрос GET на возврат ответа Hello World! В данном случае он не нужен
                //  {
                //      await context.Response.WriteAsync("Hello World!");
                //  });
            });
        }
    }
}
