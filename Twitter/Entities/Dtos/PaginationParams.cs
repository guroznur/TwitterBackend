﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class PaginationParams
    {
        private const int _maxItemsPerPage = 10;
        private int itemsPerPage;
        public int Page { get; set; } = 1;
        public int ItemsPerPage 
        { 
            get => itemsPerPage;
            set => itemsPerPage = value > _maxItemsPerPage ? _maxItemsPerPage : value; }
    }
}
