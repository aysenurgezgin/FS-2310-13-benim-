﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Shared.DTOs
{
    public class AddCategoryDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public bool IsActive { get; set; }
    }
}
