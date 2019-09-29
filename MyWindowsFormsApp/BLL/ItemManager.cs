using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWindowsFormsApp.Repository;

namespace MyWindowsFormsApp.BLL
{
   public class ItemManager
   {
       private ItemRepository _itemRepository = new ItemRepository();

       public bool Add(string name, double price)
       {
           return _itemRepository.Add(name, price);
       }

       public bool IsNameExist(string name)
       {
           return _itemRepository.IsNameExist(name);
       }

       public bool Update(string name, double price, int id)
       {
           return _itemRepository.Update(name, price, id);
       }

       public bool Delete(int id)
       {
           return _itemRepository.Delete(id);
       }
   }
}
