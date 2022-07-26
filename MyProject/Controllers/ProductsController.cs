namespace MyProject.Controllers;

public class ProductsController : SurfaceController
{
    private readonly IProductService _productService;
    private readonly IimageService _imageService;
    public ProductsController(IProductService productService, IimageService iimageService, IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory, ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider) 
        : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
    {
        _productService = productService;
        _imageService = iimageService;
    }
}
