using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemLookupGui
{

    class ItemLookup
    {
        ItemLookupEntities db;

        public ItemLookup()
        {
            db = new ItemLookupEntities();
        }

        public List<string> FindItems(string itemName)
        {
            List<ItemList> itemListList = db.ItemLists.Where(itemList => itemList.ItemName.Contains(itemName)).ToList();
            return itemListList.SelectMany(itemList => new List<string> { $"{itemList.ItemID} - {itemList.ItemName}" }).ToList();
        }
    }
}
