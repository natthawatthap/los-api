﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace los_api.Models
{
    public class Stock
    {
        public int id { get; set; }
        public int productId { get; set; }
        public int amount { get; set; }
    }
}
