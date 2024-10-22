using System;
using System.Collections.Generic;
using System.Text;

namespace GalkinEx.Models
{
    public class partners
    {
        public int id { get; set; }
        public int typePartner { get; set; }
        public string name { get; set; }
        public string director { get; set; }
        public string email { get; set; }
        public long phone { get; set; }
        public string address { get; set; }
        public long inn { get; set; }
        public decimal rate { get; set; }
    }
}
