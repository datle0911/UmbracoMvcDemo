namespace MyProject.Controllers;

public class OrdersController : SurfaceController
{
    private readonly IOrderService _orderService;
    public OrdersController(IOrderService orderService, IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory, ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider) 
        : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
    {
        _orderService = orderService;
    }

}
