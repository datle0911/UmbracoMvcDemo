namespace MyProject;

public class Startup
{
    private readonly IWebHostEnvironment _env;
    private readonly IConfiguration _config;

    /// <summary>
    /// Initializes a new instance of the <see cref="Startup" /> class.
    /// </summary>
    /// <param name="webHostEnvironment">The web hosting environment.</param>
    /// <param name="config">The configuration.</param>
    /// <remarks>
    /// Only a few services are possible to be injected here https://github.com/dotnet/aspnetcore/issues/9337.
    /// </remarks>
    public Startup(IWebHostEnvironment webHostEnvironment, IConfiguration config)
    {
        _env = webHostEnvironment ?? throw new ArgumentNullException(nameof(webHostEnvironment));
        _config = config ?? throw new ArgumentNullException(nameof(config));
    }

    /// <summary>
    /// Configures the services.
    /// </summary>
    /// <param name="services">The services.</param>
    /// <remarks>
    /// This method gets called by the runtime. Use this method to add services to the container.
    /// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940.
    /// </remarks>
    public void ConfigureServices(IServiceCollection services)
    {
        #region Add Service lifetime
        services.AddScoped<ICustomerService, CustomerService>();
        services.AddScoped<IOrderService, OrderService>();
        services.AddScoped<IProductService, ProductService>();
        services.AddScoped<Interfaces.IUserService, UserService>();
        services.AddScoped<IimageService, ImageService>();
        #endregion
        #region Add Http Client services
        var deliveryUri = _config.GetSection("ApiUrl:DeliveryUri").Value;
        services.AddHttpClient<CustomerService>(
            client =>
            {
                // Set the base address of the named client.
                client.BaseAddress = new Uri(deliveryUri);
                client.Timeout = TimeSpan.FromSeconds(5);
            });
        services.AddHttpClient<UserService>(
            client =>
            {
                // Set the base address of the named client.
                client.BaseAddress = new Uri(deliveryUri);
                client.Timeout = TimeSpan.FromSeconds(5);
            });
        services.AddHttpClient<ProductService>(
            client =>
            {
                // Set the base address of the named client.
                client.BaseAddress = new Uri(deliveryUri);
                client.Timeout = TimeSpan.FromSeconds(7);
            });
        services.AddHttpClient<OrderService>(
            client =>
            {
                // Set the base address of the named client.
                client.BaseAddress = new Uri(deliveryUri);
                client.Timeout = TimeSpan.FromSeconds(7);
            });
        #endregion

        services.AddUmbraco(_env, _config)
            .AddBackOffice()
            .AddWebsite()
            .AddComposers()
            .Build();
    }

    /// <summary>
    /// Configures the application.
    /// </summary>
    /// <param name="app">The application builder.</param>
    /// <param name="env">The web hosting environment.</param>
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        //if (env.IsDevelopment())
        //{
        //    app.UseDeveloperExceptionPage();
        //}

        //app.UseEndpoints(u => u.MapControllers());

        app.UseUmbraco()
            .WithMiddleware(u =>
            {
                u.UseUmbracoCoreMiddleware();
                u.UseBackOffice();
                u.UseWebsite();
            })
            .WithEndpoints(u =>
            {
                u.UseInstallerEndpoints();
                u.UseBackOfficeEndpoints();
                u.UseWebsiteEndpoints();
            });

        app.UseAuthentication();

        app.UseAuthorization();

        app.UseHttpsRedirection();

        app.UseCors();
    }
}
