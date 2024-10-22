using System;
using System.Collections.Generic;
using System.Text;

namespace GalkinEx.Models
{
    public class orders
    {
        public int id { get; set; }
        public int partner_id { get; set; }
        public int manager_id { get; set; }
        public DateTime order_date { get; set; }
        public string status { get; set; }
        public Decimal prepayment { get; set; }
        public Decimal total_price { get; set; }
    }
}
