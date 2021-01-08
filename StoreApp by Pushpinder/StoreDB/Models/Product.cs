using System;
namespace StoreDB
{
    public class Product : IProduct
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public DateTime Created {get; set;}
        public decimal Price { get; set; }
        public int LocationId { get; set; }
        
        }
}