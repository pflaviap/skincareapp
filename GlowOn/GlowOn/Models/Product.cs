using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace GlowOn.Models
{
    public class Product
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public string SkinType { get; set; }
        public string Category { get; set; }
        public string AgeCategory { get; set; }
        public string Ingredients { get; set; }
        public bool ForSensitive { get; set; }
        public string ExtraInfo { get; set; }
    }
}
