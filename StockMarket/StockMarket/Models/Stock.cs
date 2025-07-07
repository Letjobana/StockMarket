﻿using StockMarket.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockMarket
{
    public class Stock
    {
        public int Id { get; set; }
        public string Symbol { get; set; } = string.Empty;
        public int CompanyName { get; set; }
        [Column(TypeName ="decimal(18,2)")]
        public decimal Purchase { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal LastDev { get; set; }
        public string Industry { get; set; } = string.Empty;
        public long  MarketCap { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}
