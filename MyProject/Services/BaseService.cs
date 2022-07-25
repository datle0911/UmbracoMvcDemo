namespace MyProject.Services;

public class BaseService
{
    protected readonly IConfiguration _configuration = null;

    public BaseService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    protected string GetUrl(string endpoint)
    {
        var endpointSection = "ApiUrl:" + endpoint;
        var url = _configuration.GetSection("ApiUrl:DeliveryUri").Value + _configuration.GetSection(endpointSection).Value;
        return url;
    }

    protected string GetUrl(string endpoint, bool minimal)
    {
        var endpointSection = "ApiUrl:" + endpoint;
        var url = _configuration.GetSection("ApiUrl:DeliveryUri").Value + _configuration.GetSection(endpointSection).Value + "?minimal=" + minimal.ToString();
        return url;
    }
}
