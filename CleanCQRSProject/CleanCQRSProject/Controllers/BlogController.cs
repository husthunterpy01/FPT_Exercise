using CleanCQRSProject.Application.Blogs.Commands.CreateBlog;
using CleanCQRSProject.Application.Blogs.Commands.DeleteBlog;
using CleanCQRSProject.Application.Blogs.Commands.UpdateBlog;
using CleanCQRSProject.Application.Blogs.Queries.GetBlogs;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanCQRSProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ApiControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllBlog()
        {
            var blogs = await Mediator.Send(new GetBlogQuery());
            return Ok(blogs);
        }

        [HttpPost]
        public async Task<IActionResult> CreatNewBlog(CreateBlogCommand command)
        {
            var createBlog = await Mediator.Send(command);
            return CreatedAtAction(nameof(GetAllBlog), new { Id = createBlog.Id }, createBlog);
        }

        [HttpPut("id")]
        public async Task<IActionResult> UpdateBlog(UpdateBlogCommand command, int id)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }

            await Mediator.Send(command);
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteBlog(int id)
        {
            var result = await Mediator.Send(new DeleteBlogCommand { Id = id });
            if (result == 0)
            {
                return BadRequest();
            }
            return NoContent();
        }
    }
}
