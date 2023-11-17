using DVP.Models;
using System;

namespace DVP.Stores
{
    public class SelectedClothesStore
    {
        private ClothesModel _selectedClothes;

        public ClothesModel SelectedClothes
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
