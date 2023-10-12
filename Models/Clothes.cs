using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVP.Models
{
    internal class Clothes
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public string Season { get; set; }
        public string Comment { get; set; }
        public int Count { get; set; }
        public int Prize { get; set; }

        public Clothes() { }
    }
}
