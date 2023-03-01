using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Service;
using Model.Blog;

namespace CMS.Controllers
{
    public class BlogPostTagController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public BlogPostTagController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet, Route("~/api/admin/BlogPostTag")]
        public async Task<IActionResult> PostTag(BlogPostTag blogPostTag)
        {
            var data = await _unitOfWork.blogPostTagServices.BlogPostTag(blogPostTag);
            return Ok(data);
        }
    }
}