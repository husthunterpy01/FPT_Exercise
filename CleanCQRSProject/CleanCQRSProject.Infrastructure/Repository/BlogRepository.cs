using CleanCQRSProject.Domain.Entity;
using CleanCQRSProject.Domain.Repository;
using CleanCQRSProject.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCQRSProject.Infrastructure.Repository
{
    public class BlogRepository : IBlogRepository
    {
        private readonly BlogDbContext _dbContext;
        public BlogRepository(BlogDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Blog> CreateAsync(Blog blog)
        {
            await _dbContext.Blogs.AddAsync(blog);
            await _dbContext.SaveChangesAsync();
            return blog;
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await _dbContext.Blogs.Where(x => x.Id == id).ExecuteDeleteAsync();
        }

        public async Task<List<Blog>> GetAllBlogAsync()
        {
            return await _dbContext.Blogs.ToListAsync();
        }

        public async Task<Blog> GetBlogByIdAsync(int id)
        {
            return await _dbContext.Blogs.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<int> UpdateAsync(int id, Blog blog)
        {
             return await _dbContext.Blogs.
                Where(x => x.Id == id).
                ExecuteUpdateAsync(setters => setters
                .SetProperty(m => m.Id, blog.Id)
                .SetProperty(m => m.Name, blog.Name)
                .SetProperty(m => m.Description, blog.Description)
                .SetProperty(m => m.Author, blog.Author)
                );
        }
    }
}
