using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using VectoDigital.Task.Editor;
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

            public async Task<IActionResult> UploadAndEditImage(IFormFile file, int h, int w)
            {
                throw new System.Exception();
            }
            //public async Task<IActionResult> UploadImages(List<IFormFile> files)
            //{
            //    foreach (var item in files)
            //    {
            //        _imageHandler.UploadImage(item);
            //    }
            //}
        }
    }
}