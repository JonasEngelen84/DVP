using DVP.Models;
using DVP.Stores;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows;

namespace DVP.ViewModels
{
    public class EmployeesDetailsComponentViewModel : ViewModelBase
    {
        private ObservableCollection<Clothes> _allEmployeeClothesCollection;

        // Zur encapsulation von _allEmployeeClothesCollection wird ein IEnumerable als pointer verwendet.
        public IEnumerable<Clothes> AllEmployeeClothesCollection => _allEmployeeClothesCollection;

        public EmployeesDetailsComponentViewModel(SelectedClothesStore _selectedClothesStore)
        {
            _allEmployeeClothesCollection = new ObservableCollection<Clothes>
            {
                new Clothes("Shirt", "Sommershirt", "XL", "Sommer", 4, 666, "Jonas", "Engelen"),
                new Clothes("Shirt", "Wintershirt", "M", "Winter", 2, 666, "Jonas", "Engelen"),
                new Clothes("Hose", "Sommerhose", "XL", "Sommer", 3, 666, "Jonas", "Engelen"),
                new Clothes("Hose", "Winterhose", "L", "Winter", 2, 666, "Jonas", "Engelen"),
                new Clothes("Jacke", "Regenjacke", "L", "", 1, 666, "Jonas", "Engelen"),
                new Clothes("Jacke", "Fleecejacke", "S", "", 1, 666, "Jonas", "Engelen"),
                new Clothes("Jacke", "Winterjacke", "XL", "Winter", 1, 666, "Jonas", "Engelen"),
                new Clothes("Kopfbedeckung", "Sommerkappe", "", "Sommer", 1, 666, "Jonas", "Engelen"),
                new Clothes("Kopfbedeckung", "Winterkappe", "", "Winter", 1, 666, "Jonas", "Engelen"),

                new Clothes("Shirt", "Sommershirt", "XL", "Sommer", 2, 132, "Markus", "Oettken"),
                new Clothes("Hose", "Sommerhose", "XL", "Sommer", 2, 132, "Markus", "Oettken"),
                new Clothes("Hose", "Winterhose", "L", "Winter", 2, 132, "Markus", "Oettken"),
                new Clothes("Jacke", "Regenjacke", "L", "", 1, 132, "Markus", "Oettken"),
                new Clothes("Jacke", "Winterjacke", "XL", "Winter", 1, 132, "Markus", "Oettken"),

                new Clothes("Shirt", "Sommershirt", "XL", "Sommer", 1, 456, "Nadine", "Molik"),
                new Clothes("Shirt", "Wintershirt", "M", "Winter", 1, 456, "Nadine", "Molik"),
                new Clothes("Hose", "Sommerhose", "XL", "Sommer", 1, 456, "Nadine", "Molik"),
                new Clothes("Hose", "Winterhose", "L", "Winter", 1, 456, "Nadine", "Molik"),
                new Clothes("Jacke", "Regenjacke", "L", "", 1, 456, "Nadine", "Molik"),
                new Clothes("Jacke", "Fleecejacke", "S", "", 1, 456, "Nadine", "Molik"),
                new Clothes("Jacke", "Winterjacke", "XL", "Winter", 1, 456, "Nadine", "Molik"),
                new Clothes("Kopfbedeckung", "Sommerkappe", "", "Sommer", 1, 456, "Nadine", "Molik"),
                new Clothes("Kopfbedeckung", "Winterkappe", "", "Winter", 1, 456, "Nadine", "Molik"),

                new Clothes("Shirt", "Sommershirt", "XL", "Sommer", 2, 798, "Daniel", "Nickol"),
                new Clothes("Shirt", "Wintershirt", "M", "Winter", 2, 798, "Daniel", "Nickol"),
                new Clothes("Hose", "Sommerhose", "XL", "Sommer", 2, 798, "Daniel", "Nickol"),
                new Clothes("Hose", "Winterhose", "L", "Winter", 2, 798, "Daniel", "Nickol"),
                new Clothes("Jacke", "Regenjacke", "L", "", 2, 798, "Daniel", "Nickol"),
                new Clothes("Jacke", "Winterjacke", "XL", "Winter", 2, 798, "Daniel", "Nickol"),
                new Clothes("Kopfbedeckung", "Sommerkappe", "", "Sommer", 2, 798, "Daniel", "Nickol")
            };
        }

        //GridViewColumnHeader _lastHeaderClicked = null;
        //ListSortDirection _lastDirection = ListSortDirection.Ascending;

        //void GridViewColumnHeaderClickedHandler(object sender,
        //                                        RoutedEventArgs e)
        //{
        //    var headerClicked = e.OriginalSource as GridViewColumnHeader;
        //    ListSortDirection direction;

        //    if (headerClicked != null)
        //    {
        //        if (headerClicked.Role != GridViewColumnHeaderRole.Padding)
        //        {
        //            if (headerClicked != _lastHeaderClicked)
        //            {
        //                direction = ListSortDirection.Ascending;
        //            }
        //            else
        //            {
        //                if (_lastDirection == ListSortDirection.Ascending)
        //                {
        //                    direction = ListSortDirection.Descending;
        //                }
        //                else
        //                {
        //                    direction = ListSortDirection.Ascending;
        //                }
        //            }

        //            var columnBinding = headerClicked.Column.DisplayMemberBinding as Binding;
        //            var sortBy = columnBinding?.Path.Path ?? headerClicked.Column.Header as string;

        //            Sort(sortBy, direction);

        //            if (direction == ListSortDirection.Ascending)
        //            {
        //                headerClicked.Column.HeaderTemplate =
        //                  Resources["HeaderTemplateArrowUp"] as DataTemplate;
        //            }
        //            else
        //            {
        //                headerClicked.Column.HeaderTemplate =
        //                  Resources["HeaderTemplateArrowDown"] as DataTemplate;
        //            }

        //            // Remove arrow from previously sorted header
        //            if (_lastHeaderClicked != null && _lastHeaderClicked != headerClicked)
        //            {
        //                _lastHeaderClicked.Column.HeaderTemplate = null;
        //            }

        //            _lastHeaderClicked = headerClicked;
        //            _lastDirection = direction;
        //        }
        //    }
        //}

        //private void Sort(string sortBy, ListSortDirection direction)
        //{
        //    ICollectionView dataView =
        //      CollectionViewSource.GetDefaultView(EmployeesDetailsListView.ItemsSource);

        //    dataView.SortDescriptions.Clear();
        //    SortDescription sd = new SortDescription(sortBy, direction);
        //    dataView.SortDescriptions.Add(sd);
        //    dataView.Refresh();
        //}
    }
}
