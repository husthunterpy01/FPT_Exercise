using Xunit;
using Moq;
using System.Threading;
using System.Threading.Tasks;
using CleanCQRSProject.Application.Blogs.Commands.UpdateBlog;
using CleanCQRSProject.Domain.Repository;
using CleanCQRSProject.Domain.Entity;

namespace CleanCQRSProject.Tests.Application.Blogs
{
    public class UpdateBlogCommandHandlerTests
    {
        [Fact]
        public async Task Handle_ValidCommand_ReturnsUpdatedBlogId()
        {
            // Arrange
            var mockRepository = new Mock<IBlogRepository>();
            var handler = new UpdateBlogCommandHandler(mockRepository.Object);
            var command = new UpdateBlogCommand
            {
                Id = 1,
                Name = "Updated Test Blog",
                Description = "Updated Test Description",
                Author = "Updated Test Author"
            };

            // Setup repository to return the ID of the updated blog
            var updatedBlogId = 1; // Assuming the same ID is returned after updating
            mockRepository.Setup(r => r.UpdateAsync(command.Id, It.IsAny<Blog>())).ReturnsAsync(updatedBlogId);

            // Act
            var result = await handler.Handle(command, CancellationToken.None);

            // Assert
            Assert.Equal(updatedBlogId, result);
        }
    }
}
