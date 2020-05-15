using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace GlowOn.Models
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string SkinType { get; set; }
        public bool IsSensitive { get; set; }
        public string AgeCategory { get; set; }
    }
}
