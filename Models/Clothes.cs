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
        public int Prize { get; set; }
        public string Comment { get; set; }

        public static ObservableCollection<Clothes> ClothesList { get; }

        public Clothes(string categorie, string name, string size, string season, int quantity, int prize)
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
