using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarsShop.Web.Models
{
    public class Star
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Magnitude { get; set; }
    }
}
