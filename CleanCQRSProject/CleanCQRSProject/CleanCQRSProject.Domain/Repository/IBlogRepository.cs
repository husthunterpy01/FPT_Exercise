using CleanCQRSProject.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCQRSProject.Domain.Repository
{
    public interface IBlogRepository
    {
        Task<List<Blog>> GetAllBlogAsync();
        Task<Blog> GetBlogByIdAsync(int id);
        Task<Blog> CreateAsync(Blog blog);
        Task<int> UpdateAsync(int id,Blog blog);
        Task<int> DeleteAsync(int id);
    }
}
