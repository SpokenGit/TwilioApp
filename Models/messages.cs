using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwilioWeb.Models
{
    public class messages
    {
        public int id { get; set; }
        public DateTime datecreated   { get; set; }
        public string to_field { get; set; }
        public string message { get; set; }
    }
}
