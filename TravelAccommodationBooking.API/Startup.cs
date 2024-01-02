using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Serilog;
using System.Reflection;
using TravelAccommodationBooking.API.Services;
using TravelAccommodationBooking.API.Utilities;
using TravelAccommodationBooking.Db;
using TravelAccommodationBooking.Db.Repositories.Interfaces;
using TravelAccommodationBooking.Db.Repositories;
using TravelAccommodationBooking.API.Utilities.Validators;
using TravelAccommodationBooking.API.Services.Interfaces;
using TravelAccommodationBooking.API.Utilities.MappingProfiles;

namespace TravelAccommodationBooking.API
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // Add services to the container
        public void ConfigureServices(IServiceCollection services)
        {
            ConfigureLogging(services);            
            ConfigureAuthentication(services);
            ConfigureAuthorization(services);
            ConfigureAutoMapper(services);
            ConfigureControllers(services);
            ConfigureScopedServices(services);
            ConfigureRepositories(services);
            ConfigureSwagger(services);
            ConfigureDbContext(services);
        }

        // Configure the HTTP request pipeline
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSerilogRequestLogging();
            app.UseExceptionLogging();
            app.UseAuthentication();
            app.UseRouting();
            app.UseAuthorization();

            // Add the Controller to the API
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            ConfigureSwaggerUI(app);

            //to get more detailed error information
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
        }

        private void ConfigureSwagger(IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Travel Accommodation Booking API v1",
                    Version = "v1"
                });
                // Include XML comments for Swagger documentation
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });
        }

        private void ConfigureSwaggerUI(IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Travel Accommodation Booking API v1");
            });
        }

            public void ConfigureLogging(IServiceCollection services)
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File("log.txt", rollingInterval: RollingInterval.Day)  // Log to a file with daily rolling
                .CreateLogger();

            services.AddLogging(builder => builder.AddSerilog()); // Add Serilog to the LoggerFactory
        }

        private void ConfigureAuthentication(IServiceCollection services)
        {
            var secretKey = Configuration["Authentication:SecretKey"];

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParametersBuilder()
                        .WithSecretKey(secretKey)
                        .WithDefaultValidationParameters()
                        .Build();
                });
        }

        private void ConfigureAuthorization(IServiceCollection services)
        {
            services.AddAuthorization();
            services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        }

        private void ConfigureScopedServices(IServiceCollection services)
        {
            services.AddScoped<TravelAccommodationBookingDbContext>();
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IPasswordHasher, PasswordHasher>();
        }

        private void ConfigureRepositories(IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
        }


        private void ConfigureAutoMapper(IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            //services.AddAutoMapper(typeof(Startup), typeof(MappingProfile));
            services.AddAutoMapper(typeof(UserProfile));

        }

        private void ConfigureControllers(IServiceCollection services)
        {
            services.AddControllers()
                .AddFluentValidation(fv => fv
                .RegisterValidatorsFromAssemblyContaining<UserValidator>()
                .RegisterValidatorsFromAssemblyContaining<LoginValidator>()
                );
        }

        private void ConfigureDbContext(IServiceCollection services)
        {
            var connectionString = Configuration.GetConnectionString("SqlServerConnection");

            // Add DbContext to the DI container
            services.AddDbContext<TravelAccommodationBookingDbContext>(options =>
                options.UseSqlServer(connectionString));
        }
    }
}
