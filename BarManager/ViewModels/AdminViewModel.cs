using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using BarManager.Commands;

namespace BarManager.ViewModels
{
    public class AdminViewModel : BaseVM
    {
        private ICommand disconnectButtonCommand;
        private Action<object> _action;

        public AdminViewModel(Action<object> switchToLogIn)
        {
            _action = switchToLogIn;
        }
        public ICommand DisconnectButtonCommand
        {
            get
            {
                if (disconnectButtonCommand == null)
                {
                    disconnectButtonCommand = new RelayCommand(SwitchToLogIn);
                }
                return disconnectButtonCommand;
            }

        }

        public void SwitchToLogIn(object obj)
        {
            _action.Invoke(obj);
        }
    }
}
