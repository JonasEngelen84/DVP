using DVP.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVP.Models
{
    public class Clothes
    {
        public string Categorie { get; set; }
        public string Name { get; set; }
        public string Season { get; set; }
        public string Size { get; }
        public int Quantity { get; set; }
        public double Prize { get; set; }
        public string Comment { get; set; }

        public ClothesCollectionProvider _clothesCollectonProvider = new ClothesCollectionProvider();

        public Clothes(string categorie, string name, string size, string season, int quantity, double prize)
        {
            Categorie = categorie;
            Name = name;
            Size = size;
            Season = season;
            Quantity = quantity;
            Prize = prize;
        }
    }
}
