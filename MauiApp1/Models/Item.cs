using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MauiApp1.Models
{
    public class Item
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
