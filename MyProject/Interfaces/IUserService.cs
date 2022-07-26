namespace MyProject.Interfaces;

public interface IUserService
{
    public Task<IEnumerable<UserViewModel>> GetUserByNameAsync(string fullName);
}
