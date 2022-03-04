using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTrainingBatch3.Models
{
   public class Patient
    {
        public int id { get; set; }
        public string name { get; set; }
        public string mob { get; set; }
        public string ailment { get; set; }
     
    }

    public class Category
    {
        public int id { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
    }

    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
    }
}
