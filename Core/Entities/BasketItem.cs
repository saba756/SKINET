using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
   public class BasketItem
    {
        public int Id { get; set;}
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string PictureUrl { get; set; }
        public string Brands { get; set; }
        public string Type { get; set; }
    }
}
