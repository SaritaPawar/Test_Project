using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCBridge.Models
{
    public class MVCProductModel
    {
        public int ID { get; set; }
        [Required(ErrorMessage="This Field is required")]
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<double> Price { get; set; }
        public Nullable<int> Quantity { get; set; }
    }
}