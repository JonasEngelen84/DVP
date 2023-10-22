using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVP.Models
{
    internal abstract class Clothes
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public string Season { get; set; }
        public int Count { get; set; }
        public int Prize { get; set; }
        public string Comment { get; set; }

        //public Clothes(string name, string size, string season, int count, int prize)
        //{
        //    Name = name;
        //    Size = size;
        //    Season = season;
        //    Count = count;
        //    Prize = prize;
        //}
    }
}
