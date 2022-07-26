﻿namespace MyProject.Controllers;
public class CustomersController : SurfaceController
{
    private readonly ICustomerService _customerService;
    public CustomersController(IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory, ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider, ICustomerService customerService) 
        : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
    {
        _customerService = customerService;
    }

    public async Task<IEnumerable<Customer>> GetCustomersList()
    {
        var customers = await _customerService.GetAllCustomersAsync();
        return customers;
    }

    public IActionResult Render()
    {
        var customer = new Customer();
        return PartialView("CustomerForm", customer);
    }

    [HttpPost]
    [ValidateUmbracoFormRouteString]
    [ActionName("Submit")]
    public async Task<IActionResult> SubmitOnPost(Customer model)
    {
        if( model.CustomerUserName is null ||
            model.CustomerPassword is null || 
            model.CustomerFullName is null || 
            model.CustomerPhoneNumber is null || 
            model.CustomerEmail is null)
        {
            var response = new Response("FIELD(S) ARE MISSING", 404);
            ViewBag.Response = response;
            return View("ResponsePage");
        }

        var result = await _customerService.PostCustomerAsync(model);
        ViewBag.Response = result;
        return View("ResponsePage");
    }

}
