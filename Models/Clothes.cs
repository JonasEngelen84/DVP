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

        public Clothes(string categorie, string name, string size, string season, int quantity, double prize)
        {
            Categorie = categorie;
            Name = name;
            Size = size;
            Season = season;
            Quantity = quantity;
            Prize = prize;
        }

        public Clothes(string categorie, string name, string size, string season, int quantity)
        {
            Categorie = categorie;
            Name = name;
            Size = size;
            Season = season;
            Quantity = quantity;
        }
    }
}
