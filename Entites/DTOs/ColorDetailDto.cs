using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entites.DTOs
{
   public  class ColorDetailDto : IDto
    {
        public int ColorId { get; set; }
        public string ColorName { get; set; }
        public int CarId { get; set; }
        public string ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Descriptions { get; set; }
        public int BrandId { get; set; }
    }
}
