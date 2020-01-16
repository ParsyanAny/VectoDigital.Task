using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using VectoDigital.Task.ImageHelper;

namespace VectoDigital.Task
{
    public class ImageController : Controller
    {
        [Route("api/image")]
        public class ImagesController : Controller
        {
            private readonly IImageHandler _imageHandler;
            public ImagesController(IImageHandler imageHandler) => _imageHandler = imageHandler;
            public async Task<IActionResult> UploadImage(IFormFile file)
                => await _imageHandler.UploadImage(file);
        }
    }
}