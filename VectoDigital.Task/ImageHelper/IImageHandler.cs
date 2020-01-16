using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace VectoDigital.Task.ImageHelper
{
    public interface IImageHandler
    {
        Task<IActionResult> UploadImage(IFormFile file);
    }
}
