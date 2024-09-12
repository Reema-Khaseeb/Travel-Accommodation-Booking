using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Serilog;
using System.Reflection;
using TravelAccommodationBooking.Services;
using TravelAccommodationBooking.Db;
using TravelAccommodationBooking.Db.Repositories.Interfaces;
using TravelAccommodationBooking.Db.Repositories;
using TravelAccommodationBooking.Services.Interfaces;
using TravelAccommodationBooking.MappingProfiles;

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

                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = "JWT Authorization header using the Bearer scheme. Enter 'Bearer' [space] and then your token in the text input below. Example: 'Bearer 12345abcdef'",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
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
                        Array.Empty<string>() //new string[] { }
                    }
            });
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
            services.AddScoped<IPasswordHasher, PasswordHasher>();
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IRoomService, RoomService>();
            services.AddScoped<IBookingService, BookingService>();
            services.AddScoped<ICityService, CityService>();
            services.AddScoped<IHotelService, HotelService>();
        }

        private void ConfigureRepositories(IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IRoomRepository, RoomRepository>();
            services.AddScoped<IBookingRepository, BookingRepository>();
            services.AddScoped<ICityRepository, CityRepository>();
            services.AddScoped<IHotelRepository, HotelRepository>();
        }

        private void ConfigureAutoMapper(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(UserProfile));
        }

        private void ConfigureControllers(IServiceCollection services)
        {
            services.AddControllers()
                .AddJsonOptions(options =>
                {
                    options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve;
                })
                .AddFluentValidation(fv => fv
                .RegisterValidatorsFromAssemblyContaining<Startup>());
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
