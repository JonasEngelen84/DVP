using DVP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVP.Stores
{
    public class SelectedClothesStore
    {
        private Clothes _selectedClothes;

        public Clothes SelectedClothes
        {
            get
            {
                return _selectedClothes;
            }
            set
            {
                _selectedClothes = value;
                SelectedClothesChanged?.Invoke();

            }
        }

        public event Action SelectedClothesChanged;
    }
}
