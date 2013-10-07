using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PresentationWebForms.Models
{
    public class Item
    {
        [Required]
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public Nullable<int> QuantityAvailable { get; set; }
        public Nullable<decimal> ItemCost { get; set; }
        public Nullable<decimal> Price { get; set; }
    
        
    }
}