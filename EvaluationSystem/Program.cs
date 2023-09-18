using EvaluationSystem.Data;
using EvaluationSystem.Services.JWTTokenServices;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace EvaluationSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);
            double jwtDurationDays = 30;
            string jwtKey = GenerateRandomKey(32);


            // Add services to the container.

            builder.Services.AddControllers();
            var connectionString = builder
                           .Configuration
                           .GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException();

            builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));
            //Services Dependency Injection

            builder.Services.AddScoped<IJWTService, JWTService>(provider =>
                new JWTService(jwtKey, jwtDurationDays));

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            var app = builder.Build();


            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }

        private static string GenerateRandomKey(int lengthInBytes)
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] keyBytes = new byte[lengthInBytes];
                rng.GetBytes(keyBytes);
                return Convert.ToBase64String(keyBytes);
            }
        }

    }
}


