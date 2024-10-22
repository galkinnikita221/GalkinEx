using System;
using System.Collections.Generic;
using System.Text;

namespace GalkinEx.Models
{
    public class material
    {
        public int id { get; set; }
        public string name { get; set; }
        public int material_type_id { get; set; }
        public int quantity { get; set; }
        public string unit { get; set; }
        public int min_quantity { get; set; }
    }
}
