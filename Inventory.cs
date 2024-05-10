using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_TASK_2_PROG6221
{
    internal class Inventory
    {
        private Dictionary<string, List<InventoryItem>> itemsByCategory;

        public Inventory()
        {
            itemsByCategory = new Dictionary<string, List<InventoryItem>>();
        }

        public void AddItem(InventoryItem item)
        {
            if (!itemsByCategory.ContainsKey(item.Category))
            {
                itemsByCategory[item.Category] = new List<InventoryItem>();
            }
            itemsByCategory[item.Category].Add(item);
        }

        public void RemoveItem(InventoryItem item)
        {
            if (itemsByCategory.ContainsKey(item.Category))
            {
                itemsByCategory[item.Category].Remove(item);
            }
        }

        public void DisplayInventory()
        {
            foreach (var category in itemsByCategory)
            {
                Console.WriteLine($"Category: {category.Key}");
                foreach (var item in category.Value)
                {
                    Console.WriteLine($"Name: {item.Name}, Price: {item.Price}, Quantity: {item.Quantity}");
                }
                Console.WriteLine();
            }
        }
    }
}

