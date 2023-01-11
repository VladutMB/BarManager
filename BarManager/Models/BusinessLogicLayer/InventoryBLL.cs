using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarManager.Models.BusinessLogicLayer
{
    public class InventoryBLL
    {
        public rokuEntities context= new rokuEntities();
        public ObservableCollection<inventory> Inventories { get; set; }

        public InventoryBLL()
        {
            Inventories = new ObservableCollection<inventory>();
        }

        public void Vanzare(int IdProdus)
        {
            List<inventory> inventory = context.inventory.ToList();
            foreach(inventory item in context.inventory)
            {
                if(item.productID == IdProdus)
                {
                    item.stock--;
                    
                    break;
                }
            }
            context.SaveChanges();
        }
        public void UndoVanzare(int IdProdus)
        {
            List<inventory> inventory = context.inventory.ToList();
            foreach (inventory item in context.inventory)
            {
                if (item.productID == IdProdus)
                {
                    item.stock++;

                    break;
                }
            }
            context.SaveChanges();
        }
        public void StockChange(int IdProdus,int Qty)
        {
            List<inventory> inventory = context.inventory.ToList();
            foreach (inventory item in context.inventory)
            {
                if (item.productID == IdProdus)
                {
                    item.stock = Qty;
                    break;
                }
            }
            context.SaveChanges();
        }
    }
}
