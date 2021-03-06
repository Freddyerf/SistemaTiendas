﻿using Final.Models.Entities;
using Final.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models.ManageViewModels
{
    public class StockViewModel
    {
        public IEnumerable<Product> Products { get; set; }
    }
}
