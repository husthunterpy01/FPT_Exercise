using CleanCQRSProject.Application.Blogs.Queries.GetBlogs;
using CleanCQRSProject.Domain.Entity;
using CleanCQRSProject.Domain.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCQRSProject.Application.Blogs.Commands.CreateBlog
{
    public class CreateBlogCommandHandler : IRequestHandler<CreateBlogCommand, BlogVm>
    {
        private readonly IBlogRepository _blogRepository;
        public CreateBlogCommandHandler(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public async Task<BlogVm> Handle(CreateBlogCommand request, CancellationToken cancellationToken)
        {
            var newBlog = new Blog()
            {
                Name = request.Name,
                Description = request.Description,
                Author = request.Author
            };
            var result = await _blogRepository.CreateAsync(newBlog);
            return new BlogVm
            {
                Id = result.Id,
                Name = result.Name, 
                Description = result.Description,
                Author = result.Author,
            };
        }
    }
}
