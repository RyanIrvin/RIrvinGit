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
            return JoinItemList(itemListList);
        }

        private List<string> JoinItemList(List<ItemList> itemLists)
        {
            List<string> list = new List<string>();
            foreach(ItemList itemList in itemLists)
            {
                list.Add($"{itemList.ItemID} - {itemList.ItemName}");
            }
            return list;
        }
    }
}
