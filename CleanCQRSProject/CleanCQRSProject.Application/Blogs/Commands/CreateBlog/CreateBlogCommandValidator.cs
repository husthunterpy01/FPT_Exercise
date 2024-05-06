using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCQRSProject.Application.Blogs.Commands.CreateBlog
{
    public class CreateBlogCommandValidator : AbstractValidator<CreateBlogCommand>
    {
        public CreateBlogCommandValidator()
        {
            RuleFor(v => v.Name)
            .NotEmpty().WithMessage("Name must not be empty")
            .MaximumLength(200).WithMessage("Name not exceed 200 characters");

            RuleFor(v => v.Description)
            .NotEmpty().WithMessage("Description must be filled");

            RuleFor(v => v.Author)
            .NotEmpty().WithMessage("Author name must be filled")
            .MaximumLength(20).WithMessage("Author name must not exceed 20 characters");
        }
    }
}
