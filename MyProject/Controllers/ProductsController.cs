namespace MyProject.Controllers;

public class ProductsController : SurfaceController
{
    private readonly IProductService _productService;
    private readonly IImageService _imageService;
    public ProductsController(IProductService productService, IImageService imageService, IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory, ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider) 
        : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
    {
        _productService = productService;
        _imageService = imageService;
    }

    //public async Task<IActionResult> ProductDetails(int id)
    //{
    //    var product = await _productService.GetProductDetailsById(id);
    //    return View(id);
    //}
    public async Task<IActionResult> ProductDetails(int id)
    {
        var product = await _productService.GetProductDetailsById(id);
        return Ok(product);
    }
}
