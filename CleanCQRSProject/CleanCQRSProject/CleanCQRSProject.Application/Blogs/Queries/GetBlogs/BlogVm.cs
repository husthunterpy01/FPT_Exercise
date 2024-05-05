using AutoMapper;
using CleanCQRSProject.Application.Common.Mapping;
using CleanCQRSProject.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCQRSProject.Application.Blogs.Queries.GetBlogs
{
    // Actually this is like the query result
    public class BlogVm : IMapFrom<Blog>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
    }
}
