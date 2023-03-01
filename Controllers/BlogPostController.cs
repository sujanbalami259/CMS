using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Service;
using Model.Blog;

namespace CMS.Controllers
{
    public class BlogPostController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public BlogPostController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet, Route("~/api/admin/BlogPost")]
        public async Task<IActionResult> Post(BlogPost blogPost)
        {
            var data = await _unitOfWork.blogPostService.BlogPost(blogPost);
            return Ok(data);

        }
    }
}