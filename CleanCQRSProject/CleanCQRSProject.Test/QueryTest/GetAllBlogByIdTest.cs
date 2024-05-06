using Xunit;
using Moq;
using AutoMapper;
using System.Threading;
using System.Threading.Tasks;
using CleanCQRSProject.Application.Blogs.Queries.GetBlogById;
using CleanCQRSProject.Application.Blogs.Queries.GetBlogs;
using CleanCQRSProject.Domain.Entity;
using CleanCQRSProject.Domain.Repository;

namespace CleanCQRSProject.Tests.Application.Blogs
{
    public class GetBlogByIdQueryHandlerTests
    {
        [Fact]
        public async Task Handle_ValidQuery_ReturnsBlogVm()
        {
            // Arrange
            var blogId = 1;
            var mockRepository = new Mock<IBlogRepository>();
            var mockMapper = new Mock<IMapper>();

            // Setup repository to return a blog
            var expectedBlog = new Blog { Id = blogId, Name = "Test Blog", Description = "Test Description", Author = "Test Author" };
            mockRepository.Setup(r => r.GetBlogByIdAsync(blogId)).ReturnsAsync(expectedBlog);

            // Setup mapper to map the blog to a BlogVm
            var expectedBlogVm = new BlogVm { Id = blogId, Name = "Test Blog", Description = "Test Description", Author = "Test Author" };
            mockMapper.Setup(m => m.Map<BlogVm>(expectedBlog)).Returns(expectedBlogVm);

            var handler = new GetBlogByIdQueryrHandler(mockRepository.Object, mockMapper.Object);
            var query = new GetBlogByIdQuery { BlogId = blogId };

            // Act
            var result = await handler.Handle(query, CancellationToken.None);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(expectedBlogVm.Id, result.Id);
            Assert.Equal(expectedBlogVm.Name, result.Name);
            Assert.Equal(expectedBlogVm.Description, result.Description);
            Assert.Equal(expectedBlogVm.Author, result.Author);
        }
    }
}
