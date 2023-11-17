using DVP.ViewModels;
using System.Windows.Controls;

namespace DVP.Views
{
    /// <summary>
    /// Interaktionslogik für DVPView.xaml:
    /// Wird wie alle anderen Views durch DataContext übergangen
    /// auf die selbst angelegte Klasse "DVPViewModel".
    /// </summary>
    public partial class DVPView : UserControl
    {
        public DVPView()
        {
            InitializeComponent();
        }
    }
}
