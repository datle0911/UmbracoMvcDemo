namespace MyProject.Controllers;
public class CustomersController : SurfaceController
{
    public CustomersController(
        IUmbracoContextAccessor umbracoContextAccessor,
        IUmbracoDatabaseFactory databaseFactory,
        ServiceContext services,
        AppCaches appCaches,
        IProfilingLogger profilingLogger,
        IPublishedUrlProvider publishedUrlProvider)
        : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
    {
    }

    public IActionResult Index()
    {
        return Content("Hello world");
    }
}
//public class CustomersController : SurfaceController
//{
//    private readonly ICustomerService _customerService;

//    public CustomersController(ICustomerService customerService)
//    {
//        _customerService = customerService;
//    }

//    [HttpGet]
//    [Route("api/[controller]")]
//    public ActionResult GetAllCustomers()
//    {
//        var result = _customerService.GetAllCustomersAsync();
//        return Ok(result);
//        //return ViewComponent(result.Result.ToString());
//    }

//    [HttpGet("{fullName}")]
//    public ActionResult GetCustomerByFullName(string fullName)
//    {
//        var result = _customerService.GetCustomerByFullNameAsync(fullName);
//        return Ok(result);
//        //return ViewComponent(result.Result.ToString());
//    }
//}
