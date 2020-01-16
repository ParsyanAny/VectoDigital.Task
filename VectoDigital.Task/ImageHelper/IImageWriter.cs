using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace VectoDigital.Task.ImageHelper
{
        public interface IImageWriter
        {
            Task<string> UploadImage(IFormFile file);
        }
}
