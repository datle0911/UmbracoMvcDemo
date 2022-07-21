namespace MyProject.Controllers;
public class CustomerFormController : SurfaceController
{
    public CustomerFormController(IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory, ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider) 
        : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
    {
    }

    public IActionResult Render()
    {
        var customer = new CustomerViewModel();
        return PartialView("CustomerForm", customer);
    }

    [HttpPost]
    [ValidateUmbracoFormRouteString]
    [ActionName("Submit")]
    public IActionResult Submit(CustomerViewModel model)
    {
        if( model.CustomerUserName is null ||
            model.CustomerPassword is null || 
            model.CustomerFullName is null || 
            model.CustomerPhoneNumber is null || 
            model.CustomerEmail is null)
        {
            return BadRequest("Failed to save (one or more index be null)");
        }
        return Ok("Infomation Saved");
    }
}
