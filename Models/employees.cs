using System;
using System.Collections.Generic;
using System.Text;

namespace GalkinEx.Models
{
    public class employees
    {
        public int id { get; set; }
        public string full_name { get; set; }
        public DateTime birth_date { get; set; }
        public string passport_data { get; set; }
        public string bank_details { get; set; }
        public string family_status { get; set; }
        public string health_status { get; set; }
    }
}
