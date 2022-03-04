using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebFormsExample.Models
{
    public class ChristmasPresent
    {
        public int id { get; set; }
        public string nameOfKid { get; set; }
        public string present { get; set; }
    }

    public class ChristmasContext: DbContext
    {
        public DbSet<ChristmasPresent> cPresent { get; set; }
    }
}