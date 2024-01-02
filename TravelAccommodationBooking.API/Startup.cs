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
            ConfigureDbContext(services);
        }

        // Configure the HTTP request pipeline
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
            app.UseAuthentication();
            app.UseRouting();
            app.UseAuthorization();

            // Add the Controller to the API
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            //to get more detailed error information
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
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
