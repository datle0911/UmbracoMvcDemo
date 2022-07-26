namespace MyProject.Services;

public class ImageService : IimageService
{
    public FileContentResult GetImage(ProductViewModel productViewModel)
    {
        var image = productViewModel.ProductImage;

        return new FileContentResult(image, "ProductImage.jpg");
    }
}
