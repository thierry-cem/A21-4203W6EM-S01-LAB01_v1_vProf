using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StarsShop.Web.Models
{
    public class StarType
    {
        public int Id { get; set; }
        [Display(Name ="Type Name"), Required(ErrorMessage = "Type Name has to be filled")]
        public string TypeName { get; set; }
    }
}
