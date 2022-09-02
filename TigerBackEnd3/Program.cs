using Microsoft.EntityFrameworkCore;
using TigerPhoneAPI.Contexts;

namespace TigerPhoneAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add databse context
            builder.Services.AddDbContext<TelecomContext>(opt =>
                opt.UseSqlServer(
                    builder.Configuration.GetConnectionString("Test Connection2")
                    ));

            //builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}