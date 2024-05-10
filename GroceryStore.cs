using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_TASK_2_PROG6221
{
    internal class GroceryStore
    {
        public Inventory Inventory { get; }

        public GroceryStore()
        {
            Inventory = new Inventory();
        }
        
    }
}
