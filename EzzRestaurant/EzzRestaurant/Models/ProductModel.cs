using System;

namespace EzzRestaurant.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string img { get; set; }
    }
}