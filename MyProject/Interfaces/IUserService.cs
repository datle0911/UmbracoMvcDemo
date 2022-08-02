namespace MyProject.Interfaces;

public interface IUserService
{
    public Task<IEnumerable<User>> GetUserByNameAsync(string fullName);
}
