using DVP.Stores;
using DVP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVP.Commands
{
    public class FilterListViewCommand : CommandBase
    {
        private DVPViewModel dVPViewModel;

        public FilterListViewCommand(DVPViewModel dVPViewModel)
        {
            this.dVPViewModel = dVPViewModel;
        }

        public override void Execute(object parameter)
        {
            //TODO: das Command testen
        }
    }
}
