///var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

///builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
///builder.Services.AddEndpointsApiExplorer();
///builder.Services.AddSwaggerGen();

///var app = builder.Build();

// Configure the HTTP request pipeline.
///if (app.Environment.IsDevelopment())
///{
////    app.UseSwagger();
 ////   app.UseSwaggerUI();
///}

///app.UseHttpsRedirection();

///app.UseAuthorization();

///app.MapControllers();

//app.Run();

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using WebApi.DBOperations;

namespace WebApi
{
    public class Program
    {
        public static void Main(string[]args)
        {
            var host = CreateHostBuilder(args).Build();

            using (var scope=host.Services.CreateScope())
            {
                var services=scope.ServiceProvider;
                DataGenerator.Initialize(services);
            }
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
    }
}
