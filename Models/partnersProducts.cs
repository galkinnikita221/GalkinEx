using System;
using System.Collections.Generic;
using System.Text;

namespace GalkinEx.Models
{
    public class partnersProducts
    {
        public int id { get; set; }
        public int product_id { get; set; }
        public int partner_id { get; set; }
        public int count { get; set; }
        public DateTime dateSale { get; set; }
    }
}
