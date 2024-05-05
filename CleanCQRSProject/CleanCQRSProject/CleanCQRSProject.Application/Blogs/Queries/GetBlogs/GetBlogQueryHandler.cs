using AutoMapper;
using CleanCQRSProject.Domain.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CleanCQRSProject.Application.Blogs.Queries.GetBlogs
{
    public class GetBlogQueryHandler : IRequestHandler<GetBlogQuery, List<BlogVm>>
    {
        private readonly IBlogRepository _blogRepository;
        private readonly IMapper _mapper;
        public GetBlogQueryHandler(IBlogRepository blogRepository, IMapper mapper)
        {
            _blogRepository = blogRepository;
            _mapper = mapper;
        }
        public async Task<List<BlogVm>> Handle(GetBlogQuery request, CancellationToken cancellationToken) // Return type: Entity
        {
            var blogAcquired = await _blogRepository.GetAllBlogAsync(); // Return type: Domain Entity
            //var blogList = blogAcquired.Select(x => new BlogVm  // 1st way: IEnumerable, 2nd way ToList IEnumrable
            //{
            //    Id = x.Id,
            //    Name = x.Name,
            //    Description = x.Description,
            //    Author = x.Author,
            //}).ToList();

            //2nd way : Using mapper
            var blogList = _mapper.Map<List<BlogVm>>(blogAcquired);
            return blogList;
        }
    }
}
