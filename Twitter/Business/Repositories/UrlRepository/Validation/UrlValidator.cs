using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositories.UrlRepository.Validation
{
    public class UrlValidator : AbstractValidator<Url>
    {
        public UrlValidator()
        {
            RuleFor(p => p.TweetUrl).NotEmpty().WithMessage("Url alanı boş olamaz");
        }
    }
}
