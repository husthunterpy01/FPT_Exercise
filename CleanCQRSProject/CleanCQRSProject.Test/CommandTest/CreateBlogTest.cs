using Xunit;
using Moq;
using System.Threading;
using System.Threading.Tasks;
using CleanCQRSProject.Application.Blogs.Commands.CreateBlog;
using CleanCQRSProject.Application.Blogs.Queries.GetBlogs;
using CleanCQRSProject.Domain.Entity;
using CleanCQRSProject.Domain.Repository;

namespace CleanCQRSProject.Tests.Application.Blogs
{
    public class CreateBlogCommandHandlerTests
    {
        [Fact]
        public async Task Handle_ValidCommand_ReturnsBlogVm()
        {
            // Arrange
            var mockRepository = new Mock<IBlogRepository>();
            var handler = new CreateBlogCommandHandler(mockRepository.Object);
            var command = new CreateBlogCommand
            {
                Name = "Test Blog",
                Description = "Test Description",
                Author = "Test Author"
            };

            // Setup repository to return the newly created blog
            var createdBlog = new Blog
            {
                Id = 1,
                Name = "Test Blog",
                Description = "Test Description",
                Author = "Test Author"
            };
            mockRepository.Setup(r => r.CreateAsync(It.IsAny<Blog>())).ReturnsAsync(createdBlog);

            // Act
            var result = await handler.Handle(command, CancellationToken.None);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(createdBlog.Id, result.Id);
            Assert.Equal(createdBlog.Name, result.Name);
            Assert.Equal(createdBlog.Description, result.Description);
            Assert.Equal(createdBlog.Author, result.Author);
        }
    }
}
