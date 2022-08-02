namespace MyProject.Models.User;

public class MinimalUser
{
    public MinimalUser(string userName, string password)
    {
        UserName = userName;
        Password = password;
    }

    public string UserName { get; set; }
    public string Password { get; set; }
}
