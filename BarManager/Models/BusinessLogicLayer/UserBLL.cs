using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarManager.Models.BusinessLogicLayer
{
    public class UserBLL
    {
        public rokuEntities context = new rokuEntities();
        public ObservableCollection<user> Users { get; set; }

        public UserBLL()
        {
            Users = new ObservableCollection<user>();
        }

        public int GetUser(string user, string pass)
        {
            List<user> users = context.user.ToList();
            foreach(user x in users)
            {
                if(x.username==user && x.password==pass)
                {
                    if(x.accountType==1)
                    {
                        return 1;
                    }
                    return 2;
                }
            }
            return 0;
        }
        
    }
}
