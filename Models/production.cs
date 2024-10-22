using System;
using System.Collections.Generic;
using System.Text;

namespace GalkinEx.Models
{
    public class production
    {
        public int id { get; set; }
        public int order_id { get; set; }
        public int employee_id { get; set; }
        public int material_id { get; set; }
        public int quantity { get; set; }
        public DateTime production_date { get; set; }
    }
}
