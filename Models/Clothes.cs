using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVP.Models
{
    internal class Clothes
    {
        public string Categorie { get; set; }
        public string Name { get; set; }
        public string Season { get; set; }
        public string Size { get; set; }
        public int Count { get; set; }
        public int Prize { get; set; }
        public string Comment { get; set; }

        public Clothes(string categorie, string name, string size, string season, int count, int prize)
        {
            Categorie = categorie;
            Name = name;
            Size = size;
            Season = season;
            Count = count;
            Prize = prize;
        }
    }
}
