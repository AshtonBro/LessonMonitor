﻿
namespace EFCore.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategotyId { get; set; }
        public Category Category { get; set; }
    }
}
