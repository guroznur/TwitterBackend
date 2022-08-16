﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositories.TweetRepository.Validation
{
    public class TweetValidator : AbstractValidator<Tweet>
    {
        public TweetValidator()
        {
            RuleFor(p => p.Text).NotEmpty().WithMessage("Text alanı boş olamaz");
        }
      
    }
}
