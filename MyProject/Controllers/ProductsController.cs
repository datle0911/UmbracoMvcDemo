namespace MyProject.Controllers;

public class ProductsController : SurfaceController
{
    private readonly IProductService _productService;
    public ProductsController(IProductService productService, IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory, ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider) 
        : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
    {
        _productService = productService;
    }
}
