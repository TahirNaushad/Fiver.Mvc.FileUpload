using Microsoft.AspNetCore.Http;

namespace Fiver.Mvc.FileUpload.Models.Home
{
    public class FileInputModel
    {
        public IFormFile FileToUpload { get; set; }
    }
}
