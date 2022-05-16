using ShopMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMVC.Services
{
    public class ShopService
    {
        private List<ShopItem> _shopItems = new List<ShopItem>()
        {
            new ShopItem
            {
                Name = "Milk",
                ShopName = "Tesco",
                ExpiryDate = DateTime.Now.AddYears(1)
            }
        };

        public List<ShopItem> GetAll()
        {
            return _shopItems;
        }
        public void Add(ShopItem item)
        {
            _shopItems.Add(item);
        }
        public void Delete(string name)
        {
            _shopItems = _shopItems.Where(x => x.Name != name).ToList();
        }
    }
}
