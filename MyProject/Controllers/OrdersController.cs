namespace MyProject.Controllers;

public class OrdersController : SurfaceController
{
    private readonly IOrderService _orderService;
    private readonly IImageService _imageService;
    public OrdersController(IOrderService orderService, IImageService imageService, IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory, ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider) 
        : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
    {
        _orderService = orderService;
        _imageService = imageService;
    }

}
