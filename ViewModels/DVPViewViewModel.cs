﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DVP.ViewModels
{
    internal class DVPViewViewModel
    {
        public EmployeesDetailsComponentViewModel EmployeesDetailsViewModel { get; }
        public ClothesDetailsComponentViewModel ClothesDetailsViewModel { get; }

        public ICommand FilterDataGridCommand { get; }
        public ICommand EditModelsCommand { get; }
        public ICommand BackwardCommand { get; }
        public ICommand SafeCommand { get; }
        public ICommand PrintCommand { get; }
        public ICommand ContactCommand { get; }
        public ICommand EditPlusCommand { get; }
        public ICommand EditMinusCommand { get; }
    }
}