﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Tweet
    {
        
        public int Id { get; set; } 
        public int UserId { get; set; }
        public string Text { get; set; }
        
    }
}
