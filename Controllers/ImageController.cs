using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Service;

namespace CMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ImageController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet, Route("~/api/upload-single-image")]
        public async Task<IActionResult> ImageUpload()
        {
            var data = await _unitOfWork.imageService.UploadImage("Image");
            return Ok(data);

        }
        [HttpGet, Route("~/api/upload-bulk-image")]
        public async Task<IActionResult> ImageLoad(string req)
        {
            var data = await _unitOfWork.imageService.UploadImage(req);
            return Ok(data);

        }
    }
}
