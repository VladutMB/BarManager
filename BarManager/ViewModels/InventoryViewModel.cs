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
    public class InventoryViewModel : BaseVM
    {
        private ICommand disconnectButtonCommand;

        private ICommand blondaPressed;
        private ICommand brunaPressed;
        private ICommand faraAlcoolPressed;
        private ICommand colaPressed;
        private ICommand schweppesPressed;
        private ICommand spritePressed;
        private ICommand iceTeaPressed;
        private ICommand apaPlataPressed;
        private ICommand wjdPressed;
        private ICommand wjmPressed;
        private ICommand strohPressed;
        private ICommand havanPressed;
        private ICommand ginPressed;
        private ICommand vodkaPressed;
        private ICommand jaggerPressed;
        private ICommand absinthPressed;

        private ICommand vanzare;
        private ICommand undoVanzare;
        private Action<object> _action;

        private bool blondaVisibility;
        private bool brunaVisibility;
        private bool faraAlcoolVisibility;
        private bool colaVisibility;
        private bool schweppesVisibility;
        private bool spriteVisibility;
        private bool iceTeaVisibility;
        private bool apaPlataVisibility;
        private bool wjdVisibility;
        private bool wjmVisibility;
        private bool strohVisibility;
        private bool havanVisibility;
        private bool ginVisibility;
        private bool vodkaVisibility;
        private bool jaggerVisibility;
        private bool absinthVisibility;
        public InventoryBLL Inventory { get; set; }



        public InventoryViewModel(Action<object> switchToLogIn)
        {
            _action = switchToLogIn;
            Inventory = new InventoryBLL();
            blondaVisibility = false;
            
        }
        public bool BlondaVisibility
        {
            get { return blondaVisibility; }
            set
            {
                blondaVisibility = value;
                OnPropertyChanged("BlondaVisibility");
            }
        }
        public bool BrunaVisibility
        {
            get { return brunaVisibility; }
            set
            {
                brunaVisibility = value;
                OnPropertyChanged("BrunaVisibility");
            }
        }
        public bool FaraAlcoolVisibility
        {
            get { return faraAlcoolVisibility; }
            set
            {
                faraAlcoolVisibility = value;
                OnPropertyChanged("FaraAlcoolVisibility");
            }
        }
        public bool ColaVisibility
        {
            get { return colaVisibility; }
            set
            {
                colaVisibility = value;
                OnPropertyChanged("ColaVisibility");
            }
        }
        public bool SchweppesVisibility
        {
            get { return schweppesVisibility; }
            set
            {
                schweppesVisibility = value;
                OnPropertyChanged("SchweppesVisibility");
            }
        }
        public bool SpriteVisibility
        {
            get { return spriteVisibility; }
            set
            {
                spriteVisibility = value;
                OnPropertyChanged("SpriteVisibility");
            }
        }
        public bool IceTeaVisibility
        {
            get { return iceTeaVisibility; }
            set
            {
                iceTeaVisibility = value;
                OnPropertyChanged("IceTeaVisibility");
            }
        }
        public bool ApaPlataVisibility
        {
            get { return apaPlataVisibility; }
            set
            {
                apaPlataVisibility = value;
                OnPropertyChanged("ApaPlataVisibility");
            }
        }
        public bool WjdVisibility
        {
            get { return wjdVisibility; }
            set
            {
                wjdVisibility = value;
                OnPropertyChanged("WjdVisibility");
            }
        }
        public bool WjmVisibility
        {
            get { return wjmVisibility; }
            set
            {
                wjmVisibility = value;
                OnPropertyChanged("WjmVisibility");
            }
        }
        public bool StrohVisibility
        {
            get { return strohVisibility; }
            set
            {
                strohVisibility = value;
                OnPropertyChanged("StrohVisibility");
            }
        }
        public bool HavanVisibility
        {
            get { return havanVisibility; }
            set
            {
                havanVisibility = value;
                OnPropertyChanged("HavanVisibility");
            }
        }
        public bool GinVisibility
        {
            get { return ginVisibility; }
            set
            {
                ginVisibility = value;
                OnPropertyChanged("GinVisibility");
            }
        }
        public bool VodkaVisibility
        {
            get { return vodkaVisibility; }
            set
            {
                vodkaVisibility = value;
                OnPropertyChanged("VodkaVisibility");
            }
        }
        public bool JaggerVisibility
        {
            get { return jaggerVisibility; }
            set
            {
                jaggerVisibility = value;
                OnPropertyChanged("JaggerVisibility");
            }
        }
        public bool AbsinthVisibility
        {
            get { return absinthVisibility; }
            set
            {
                absinthVisibility = value;
                OnPropertyChanged("AbsinthVisibility");
            }
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
        
        public ICommand BlondaPressed
        {
            get
            {
                if (blondaPressed == null)
                {
                    blondaPressed = new RelayCommand(MakeBlondaVisible);
                }
                return blondaPressed;
            }
        }
        public ICommand BrunaPressed
        {
            get
            {
                if (brunaPressed == null)
                {
                    brunaPressed = new RelayCommand(MakeBrunaVisible);
                }
                return brunaPressed;
            }
        }
        public ICommand FaraAlcoolPressed
        {
            get
            {
                if (faraAlcoolPressed == null)
                {
                    faraAlcoolPressed = new RelayCommand(MakeFaraAlcoolVisible);
                }
                return faraAlcoolPressed;
            }
        }
        public ICommand ColaPressed
        {
            get
            {
                if (colaPressed == null)
                {
                    colaPressed = new RelayCommand(MakeColaVisible);
                }
                return colaPressed;
            }
        }
        public ICommand SchweppesPressed
        {
            get
            {
                if (schweppesPressed == null)
                {
                    schweppesPressed = new RelayCommand(MakeSchweppesVisible);
                }
                return schweppesPressed;
            }
        }
        public ICommand SpritePressed
        {
            get
            {
                if (spritePressed == null)
                {
                    spritePressed = new RelayCommand(MakeSpriteVisible);
                }
                return spritePressed;
            }
        }
        public ICommand IceTeaPressed
        {
            get
            {
                if (iceTeaPressed == null)
                {
                    iceTeaPressed = new RelayCommand(MakeIceTeaVisible);
                }
                return iceTeaPressed;
            }
        }
        public ICommand ApaPlataPressed
        {
            get
            {
                if (apaPlataPressed == null)
                {
                    apaPlataPressed = new RelayCommand(MakeApaPlataVisible);
                }
                return apaPlataPressed;
            }
        }
        public ICommand WjdPressed
        {
            get
            {
                if (wjdPressed == null)
                {
                    wjdPressed = new RelayCommand(MakeWjdVisible);
                }
                return wjdPressed;
            }
        }
        public ICommand WjmPressed
        {
            get
            {
                if (wjmPressed == null)
                {
                    wjmPressed = new RelayCommand(MakeWjmVisible);
                }
                return wjmPressed;
            }
        }
        public ICommand StrohPressed
        {
            get
            {
                if (strohPressed == null)
                {
                    strohPressed = new RelayCommand(MakeStrohVisible);
                }
                return strohPressed;
            }
        }
        public ICommand HavanPressed
        {
            get
            {
                if (havanPressed == null)
                {
                    havanPressed = new RelayCommand(MakeHavanVisible);
                }
                return havanPressed;
            }
        }
        public ICommand GinPressed
        {
            get
            {
                if (ginPressed == null)
                {
                    ginPressed = new RelayCommand(MakeGinVisible);
                }
                return ginPressed;
            }
        }
        public ICommand VodkaPressed
        {
            get
            {
                if (vodkaPressed == null)
                {
                    vodkaPressed = new RelayCommand(MakeVodkaVisible);
                }
                return vodkaPressed;
            }
        }
        public ICommand JaggerPressed
        {
            get
            {
                if (jaggerPressed == null)
                {
                    jaggerPressed = new RelayCommand(MakeJaggerVisible);
                }
                return jaggerPressed;
            }
        }
        public ICommand AbsinthPressed
        {
            get
            {
                if (absinthPressed == null)
                {
                    absinthPressed = new RelayCommand(MakeAbsinthVisible);
                }
                return absinthPressed;
            }
        }

        public ICommand Vanzare
        {
            get
            {
                if (vanzare == null)
                {
                    vanzare = new RelayCommand(Vinde);
                }
                return vanzare;
            }
            
        }
        public ICommand UndoVanzare
        {
            get
            {
                if (undoVanzare == null)
                {
                    undoVanzare = new RelayCommand(UndoVinde);
                }
                return undoVanzare;
            }
        }

        public void SwitchToLogIn(object obj)
        {
            _action.Invoke(obj);
        }

        public void MakeBlondaVisible(object obj)
        {
            BlondaVisibility = !BlondaVisibility;
        }
        public void MakeBrunaVisible(object obj)
        {
            BrunaVisibility = !BrunaVisibility;
        }
        public void MakeFaraAlcoolVisible(object obj)
        {
            FaraAlcoolVisibility = !FaraAlcoolVisibility;
        }
        public void MakeColaVisible(object obj)
        {
            ColaVisibility = !ColaVisibility;
        }
        public void MakeSchweppesVisible(object obj)
        {
            SchweppesVisibility = !SchweppesVisibility;
        }
        public void MakeSpriteVisible(object obj)
        {
            SpriteVisibility = !SpriteVisibility;
        }
        public void MakeIceTeaVisible(object obj)
        {
            IceTeaVisibility = !IceTeaVisibility;
        }
        public void MakeApaPlataVisible(object obj)
        {
            ApaPlataVisibility = !ApaPlataVisibility;
        }
        public void MakeWjdVisible(object obj)
        {
            WjdVisibility = !WjdVisibility;
        }
        public void MakeWjmVisible(object obj)
        {
            WjmVisibility = !WjmVisibility;
        }
        public void MakeStrohVisible(object obj)
        {
            StrohVisibility = !StrohVisibility;
        }
        public void MakeHavanVisible(object obj)
        {
            HavanVisibility = !HavanVisibility;
        }
        public void MakeGinVisible(object obj)
        {
            GinVisibility = !GinVisibility;
        }
        public void MakeVodkaVisible(object obj)
        {
            VodkaVisibility = !VodkaVisibility;
        }
        public void MakeJaggerVisible(object obj)
        {
            JaggerVisibility = !JaggerVisibility;
        }
        public void MakeAbsinthVisible(object obj)
        {
            AbsinthVisibility = !AbsinthVisibility;
        }

        public void Vinde(object obj)
        {
            int x=Int32.Parse(obj.ToString());
            Inventory.Vanzare(x);
        }
        public void UndoVinde(object obj)
        {
            int x = Int32.Parse(obj.ToString());
            Inventory.UndoVanzare(x);
        }
    }
}
