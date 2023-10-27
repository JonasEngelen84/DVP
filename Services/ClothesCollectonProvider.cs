using DVP.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVP.Services
{
    public class ClothesCollectonProvider
    {
        public ObservableCollection<Clothes> ClothesCollection { get;  }
    }
}
