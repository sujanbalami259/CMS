using Microsoft.AspNetCore.Mvc;
using Model.Blog;
using Service;
using Services;
using System.Threading.Tasks;

namespace CMS.Controllers
{
    public class UserController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet, Route("~/api/admin/user")]
        public async Task<IActionResult> Use(User user)
        {
            var data = await _unitOfWork.userService.User(user);
            return Ok(data);
        }
    }
}
