using EvaluationSystem.Data;
using EvaluationSystem.Services.JWTTokenServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

namespace EvaluationSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);

            double jwtDurationDays = 30;

            //var configuration = new ConfigurationBuilder()
            //    .AddJsonFile("appsettings.json") // Load configuration from appsettings.json
            //    .Build();

            //   string jwtKey = GenerateRandomKey(32);


            // Add services to the container.
            builder.Services.AddAuthorization(options =>
            {
                options.AddPolicy("AdminPolicy", policy => policy.RequireRole("Admin"));
            });

            builder.Services.AddControllers();
            var connectionString = builder
                           .Configuration
                           .GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException();

            builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));
            //Role Based Authorization

            builder.Services.AddAuthorization(options =>
            {
                options.AddPolicy("AdminPolicy", policy => policy.RequireRole("Admin"));
            });

            //Services Dependency Injection

            //builder.Services.AddScoped<IJWTService, JWTService>(provider =>
            //    new JWTService(jwtKey, jwtDurationDays));
            builder.Services.AddScoped<IJWTService, JWTService>();


            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            //  builder.Services.AddSwaggerGen();
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Your API", Version = "v1" });

                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = "JWT Authorization header using the Bearer scheme",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] { }
        }
    });
            });

            builder.Services.AddAuthentication().AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = builder.Configuration["Jwt:Issuer"],
                    ValidAudience = builder.Configuration["Jwt:Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
                };
            });

            //builder.Services.AddAuthentication(options =>
            //{
            //    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            //    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            //}).AddJwtBearer(options =>
            //{
            //    options.TokenValidationParameters = new TokenValidationParameters
            //    {
            //        ValidateIssuer = true,
            //        ValidateAudience = true,
            //        ValidateIssuerSigningKey = true,
            //        //ValidIssuer = builder.Configuration["Jwt:Issuer"],
            //        //ValidAudience = builder.Configuration["Jwt:Audience"],

            //        ValidIssuer = "http://yourdomain.com",
            //        ValidAudience = "YourAudience",


            //        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
            //    };
            //});


            var app = builder.Build();



            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseAuthentication();

            app.MapControllers();

            app.Run();
        }

        //private static string GenerateRandomKey(int lengthInBytes)
        //{
        //    using (var rng = new RNGCryptoServiceProvider())
        //    {
        //        byte[] keyBytes = new byte[lengthInBytes];
        //        rng.GetBytes(keyBytes);
        //        return Convert.ToBase64String(keyBytes);
        //    }
        //}

    }
}


