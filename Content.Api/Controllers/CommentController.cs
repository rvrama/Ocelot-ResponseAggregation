using Content.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Content.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommentController : ControllerBase
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }
        [HttpGet]
        public IActionResult GetAll() => Ok(_commentService.GetCommentItems());
    }
}
