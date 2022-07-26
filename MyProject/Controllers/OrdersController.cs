namespace MyProject.Controllers;

public class OrdersController : SurfaceController
{
    private readonly IOrderService _orderService;
    private readonly IimageService _imageService;
    public OrdersController(IOrderService orderService, IimageService iimageService, IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory, ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider) 
        : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
    {
        _orderService = orderService;
        _imageService = iimageService;
    }

}
