using DVP.Models;
using DVP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DVP
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ClothesCollectionProvider _clothesCollectionProvider = new ClothesCollectionProvider();
            _clothesCollectionProvider.AddClothesToCollection(new Clothes("Shirt", "Sommershirt", "XL", "Sommer", 12, 19.99));
            _clothesCollectionProvider.AddClothesToCollection(new Clothes("Shirt", "Wintershirt", "M", "Winter", 8, 19.99));
            _clothesCollectionProvider.AddClothesToCollection(new Clothes("Hose", "Sommerhose", "XL", "Sommer", 10, 50.29));
        }

    }
}
