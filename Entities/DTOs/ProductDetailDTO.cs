﻿using Core.Entities;

namespace Entities.DTOs
{
    public class ProductDetailDTO : IDTO
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public short UnitsInsotck { get; set; }
    }
}
