﻿using System.ComponentModel.DataAnnotations;

namespace AltenShop.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string InventoryStatus { get; set; }
        public string Category { get; set; }
        public string? Image { get; set; }
        public int? Rating { get; set; }
    }
}
