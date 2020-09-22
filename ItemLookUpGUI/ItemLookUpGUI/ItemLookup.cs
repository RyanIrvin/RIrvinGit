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

        public List<string> FindId(string itemName)
        {
            return db.ItemLists.Where(itemList => itemList.ItemName.Contains(itemName)).Select(ItemList => ItemList.ItemID).ToList();
        }
    }
}
