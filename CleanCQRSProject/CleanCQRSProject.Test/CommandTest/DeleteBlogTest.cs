using Xunit;
using Moq;
using System.Threading;
using System.Threading.Tasks;
using CleanCQRSProject.Application.Blogs.Commands.DeleteBlog;
using CleanCQRSProject.Domain.Repository;

namespace CleanCQRSProject.Tests.Application.Blogs
{
    public class DeleteBlogCommandHandlerTests
    {
        [Fact]
        public async Task Handle_ValidCommand_ReturnsDeletedBlogId()
        {
            // Arrange
            var blogId = 1;
            var mockRepository = new Mock<IBlogRepository>();
            var handler = new DeleteBlogCommandHandler(mockRepository.Object);
            var command = new DeleteBlogCommand { Id = blogId };

            // Setup repository to return the ID of the deleted blog
            var deletedBlogId = 1; // Assuming the same ID is returned after deletion
            mockRepository.Setup(r => r.DeleteAsync(blogId)).ReturnsAsync(deletedBlogId);

            // Act
            var result = await handler.Handle(command, CancellationToken.None);

            // Assert
            Assert.Equal(deletedBlogId, result);
        }
    }
}
