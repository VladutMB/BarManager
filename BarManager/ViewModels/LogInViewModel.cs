using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using BarManager.Commands;
using BarManager.Models.BusinessLogicLayer;

namespace BarManager.ViewModels
{
    public class LogInViewModel : BaseVM
    {
        private Action<object> _actionInventory;
        private Action<object> _actionAdmin;
        private string _userName;
        private string _password;
        public UserBLL User { get; set; }
        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                OnPropertyChanged("UserName");
            }
        }
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged("Password");
            }
        }
        private ICommand logInButtonCommand;
        public ICommand LogInButtonCommand
        {
            get
            {
                if (logInButtonCommand == null)
                {
                    logInButtonCommand = new RelayCommand(Switch);
                }
                return logInButtonCommand;
            }

        }
        public void Switch(object obj)
        {
            int type = -1;
            type = User.GetUser(UserName, Password);
            switch (type)
            {
                case 0:
                    break;
                case 1:
                    SwitchToAdmin(obj);
                    break;
                case 2:
                    SwitchToInventory(obj);
                    break;
            }
        }

        public void show(object obj)
        {
            MessageBox.Show(UserName + " " + Password);
        }
        public LogInViewModel(Action<object> switchToInventory, Action<object> switchToAdmin)
        {
            _actionInventory = switchToInventory;
            _actionAdmin = switchToAdmin;
            User = new UserBLL();
        }
        public void SwitchToInventory(object obj)
        {
            _actionInventory.Invoke(obj);
        }



        public void SwitchToAdmin(object obj)
        {
            _actionAdmin.Invoke(obj);
        }
    }
}
