using System.ComponentModel;

namespace DVP.ViewModels
{
    /// <summary>
    /// Bereitstellung des "INotifyPropertyChanged" Interface
    /// </summary>
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
