using AutoMapper;
using CleanCQRSProject.Application.Blogs.Queries.GetBlogs;
using CleanCQRSProject.Domain.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCQRSProject.Application.Blogs.Queries.GetBlogById
{
    public class GetBlogByIdQueryrHandler : IRequestHandler<GetBlogByIdQuery, BlogVm>
    {
        private readonly IBlogRepository _blogRepository;
        private readonly IMapper _mapper;
        public GetBlogByIdQueryrHandler(IBlogRepository blogRepository, IMapper mapper)
        {
            _blogRepository = blogRepository;
        }
        public async Task<BlogVm> Handle(GetBlogByIdQuery request, CancellationToken cancellationToken)
        {
            var getById = await _blogRepository.GetBlogByIdAsync(request.BlogId);
            var searchBlogVm = new BlogVm
            {
                Id = getById.Id,
                Name = getById.Name,
                Description = getById.Description,
                Author = getById.Author
            };
            return searchBlogVm;
        }
    }
}
