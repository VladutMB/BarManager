using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarManager.ViewModels
{

    public class MainWindowViewModel : BaseVM
    {
        public InventoryViewModel InventoryVM { get; set; }
        public AdminViewModel AdminVM { get; set; }

        public LogInViewModel LogInVM { get; set; }
        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged("CurrentView");
            }
        }
        public MainWindowViewModel()
        {


            LogInVM = new LogInViewModel(SwitchToInventory, SwitchToAdmin);
            CurrentView = LogInVM;

        }
        public void SwitchToInventory(object obj)
        {
            InventoryVM = new InventoryViewModel(SwitchToLogIn);
            CurrentView = InventoryVM;
        }
        public void SwitchToLogIn(object obj)
        {
            LogInVM = new LogInViewModel(SwitchToInventory, SwitchToAdmin);
            CurrentView = LogInVM;
        }
        public void SwitchToAdmin(object obj)
        {
            CurrentView = new AdminViewModel(SwitchToLogIn);
            
        }
    }
}
