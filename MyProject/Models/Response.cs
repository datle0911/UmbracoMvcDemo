namespace MyProject.Models;

public class Response
{
    public Response(string content, int statusCodes)
    {
        Content = content;
        StatusCodes = statusCodes;
    }

    public string Content { get; set; }
    public int StatusCodes { get; set; }
}
