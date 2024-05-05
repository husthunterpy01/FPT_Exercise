using CleanCQRSProject.Domain.Entity;
using CleanCQRSProject.Domain.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CleanCQRSProject.Application.Blogs.Commands.UpdateBlog
{
    public class UpdateBlogCommandHandler : IRequestHandler<UpdateBlogCommand, int>
    {
        private IBlogRepository _blogRepository;
        public UpdateBlogCommandHandler(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }
        public async Task<int> Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
        {
            var updateEntity = new Blog()
            {
                Id = request.Id,
                Author = request.Author,
                Description = request.Description,
                Name = request.Name
            };

            return await _blogRepository.UpdateAsync(request.Id, updateEntity);
        }
    }
}
