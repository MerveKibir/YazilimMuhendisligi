﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class HouseOfSale : IEntity
    {
        public int SaleHouseId { get; set; }
        public int HouseId { get; set; }
        public decimal Price { get; set; }
    }
}
