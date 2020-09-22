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

        public string FindId(string itemName)
        {
            return db.ItemLists.FirstOrDefault(itemList => itemList.ItemName.Contains(itemName)).ItemID;
        }
    }
}
