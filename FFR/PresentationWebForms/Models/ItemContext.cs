using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PresentationWebForms.Models
{
    public class ItemContext : DbContext
    {
        public ItemContext()
            : base("Presentation")
        {

        }
        public DbSet<Item> Items {get; set;}
    }
}