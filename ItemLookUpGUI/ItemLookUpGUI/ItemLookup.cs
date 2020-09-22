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

        public List<string> Find(string inputText)
        {
            return FindItems(inputText.Split(','));
        }

        private List<string> FindItems(string[] itemIdentifiers)
        {
            List<string> items = new List<string>();
            foreach(string itemIdentifier in itemIdentifiers)
            {
                items.AddRange(FindItems(itemIdentifier));
            }
            return items;
        }

        private List<string> FindItems(string itemIdentifier)
        {
            List<ItemList> itemListList = GetItemList(itemIdentifier.Trim());
            return itemListList.Count > 0 ? itemListList.SelectMany(itemList => new List<string> { $"{itemList.ItemID} - {itemList.ItemName}" }).ToList() : new List<string> { "No Results Found." };
        }

        private List<ItemList> GetItemList(string itemIdentifier)
        {
            var itemIDList = db.ItemLists.Where(itemList => itemList.ItemID.ToString().Contains(itemIdentifier)).ToList();
            var itemNameList = db.ItemLists.Where(itemList => itemList.ItemName.Contains(itemIdentifier)).ToList();
            return itemIDList.Count > 0 ? itemIDList : itemNameList;
        }
    }
}