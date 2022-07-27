namespace MyProject.Services;

public class ImageService : IImageService
{
    public FileContentResult GetImage(ProductViewModel productViewModel)
    {
        var image = productViewModel.ProductImage;

        return new FileContentResult(image, "ProductImage.jpg");
    }
}
