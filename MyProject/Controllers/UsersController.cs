namespace MyProject.Controllers;

public class UsersController : SurfaceController
{
    private readonly IProductService _productService;
    public UsersController(IProductService productService, IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory, ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider) : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
    {
        _productService = productService;
    }
}
