using System;
using System.Collections.Generic;
using System.Text;

namespace GalkinEx.Models
{
    public class product
    {
        public int id { get; set; }
        public int type { get; set; }
        public string name { get; set; }
        public string articles { get; set; }
        public decimal minPrice { get; set; }
    }
}
