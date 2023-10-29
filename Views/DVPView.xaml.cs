using DVP.ViewModels;
using System.Windows.Controls;

namespace DVP.Views
{
    /// <summary>
    /// Interaktionslogik für DVPView.xaml
    /// </summary>
    public partial class DVPView : UserControl
    {
        public DVPView()
        {
            InitializeComponent();

            this.DataContext = new DVPViewViewModel();
        }
    }
}
