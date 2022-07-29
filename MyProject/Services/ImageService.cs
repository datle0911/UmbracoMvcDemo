namespace MyProject.Services;

public class ImageService : IImageService
{
    public string GetImage(byte[] image)
    {
        string imgBase64Data = Convert.ToBase64String(image);
        string imgDataURL = string.Format("data:image/jpg;base64", imgBase64Data);
        return imgDataURL;
    }
}
