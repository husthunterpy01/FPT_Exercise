using AutoMapper;
using CleanCQRSProject.Application.Blogs.Queries.GetBlogs;
using CleanCQRSProject.Domain.Entity;
using CleanCQRSProject.Domain.Repository;
using Moq;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace CleanCQRSProject.Tests.Application.Blogs.Queries
{
    public class GetBlogQueryHandlerTests
    {
        [Fact]
        public async Task Handle_ReturnsListOfBlogVm()
        {
            // Arrange
            var mockRepository = new Mock<IBlogRepository>();
            var mockMapper = new Mock<IMapper>();

            var blogs = new List<Blog>
            {
                new Blog { Id = 1, Name = "Blog 1", Description = "Description 1", Author = "Author 1" },
                new Blog { Id = 2, Name = "Blog 2", Description = "Description 2", Author = "Author 2" }
            };

            mockRepository.Setup(repo => repo.GetAllBlogAsync()).ReturnsAsync(blogs);

            var blogVms = new List<BlogVm>
            {
                new BlogVm { Id = 1, Name = "Blog 1", Description = "Description 1", Author = "Author 1" },
                new BlogVm { Id = 2, Name = "Blog 2", Description = "Description 2", Author = "Author 2" }
            };

            mockMapper.Setup(mapper => mapper.Map<List<BlogVm>>(blogs)).Returns(blogVms);

            var handler = new GetBlogQueryHandler(mockRepository.Object, mockMapper.Object);
            var query = new GetBlogQuery();

            // Act
            var result = await handler.Handle(query, CancellationToken.None);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(blogVms.Count, result.Count);
            Assert.Equal(blogVms[0].Id, result[0].Id);
            Assert.Equal(blogVms[1].Name, result[1].Name);
            // Add additional assertions as needed for other properties
        }
    }
}
