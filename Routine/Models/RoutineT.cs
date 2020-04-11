using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Routine.Models
{
    public class RoutineT
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string MakeupRemover { get; set; }
        public string MakeupRemoverBrand { get; set; }
        public string Cleanser { get; set; }
        public string CleanserBrand { get; set; }
        public string HydratingCream { get; set; }
        public string HydratingCreamBrand { get; set; }
    }
}
