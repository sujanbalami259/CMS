using Microsoft.AspNetCore.Mvc;
using Model.Blog;
using Service;
using System.Threading.Tasks;


namespace CMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BLogController : Controller

    {

        private readonly IUnitOfWork _unitOfWork;
        public BLogController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet, Route("~/api/admin/Category")]
        public async Task<IActionResult> Catagory(BlogCatagory blogCategory)
        {

            var data = await _unitOfWork.blogCategoryService.BlogCatagory(blogCategory);
            return Ok(data);
        }


    }
}
