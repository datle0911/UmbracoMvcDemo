namespace MyProject.Services;

public class UserService : BaseService, Interfaces.IUserService
{
    private readonly HttpClient _httpClient = null!;
    public UserService(HttpClient httpClient, IConfiguration configuration) : base(configuration)
    {
        _httpClient = httpClient;
    }

    public async Task<IEnumerable<UserViewModel>> GetUserByNameAsync(string fullName)
    {
        var url = GetUrl("users");
        var response = await _httpClient.GetFromJsonAsync<IEnumerable<UserViewModel>>(url + "/" + fullName);

        if (response is not null)
        {
            return response;
        }

        return null;
    }
}
