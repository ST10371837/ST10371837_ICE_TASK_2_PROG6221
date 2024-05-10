using System;
using System.Windows.Forms;


namespace ICE_TASK_2_PROG6221
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        public partial class MainForm : Form
        {
            private GroceryStore groceryStore;
            private object itemNameTextBox;

            public MainForm()
            {
                InitializeComponent();
                groceryStore = new GroceryStore();
            }

            private void InitializeComponent()
            {
                throw new NotImplementedException();
            }

            private void AddItemButton_Click(object sender, EventArgs e)
            {
                // Add item to inventory
                InventoryItem item = new InventoryItem
                {
                    Name = itemNameTextBox.Text,
                    Price = decimal.Parse(itemPriceTextBox.Text),
                    Quantity = int.Parse(itemQuantityTextBox.Text),
                    Category = itemCategoryComboBox.SelectedItem.ToString()
                };

                groceryStore.Inventory.AddItem(item);

                // Clear input fields
                itemNameTextBox.Clear();
                itemPriceTextBox.Clear();
                itemQuantityTextBox.Clear();
                itemCategoryComboBox.SelectedIndex = -1;

                // Update display
                DisplayInventory();
            }

            private void RemoveItemButton_Click(object sender, EventArgs e)
            {
                // Remove item from inventory
                // Implement as per your requirement
            }

            private void DisplayInventory()
            {
                // Clear existing display
                inventoryListBox.Items.Clear();

                // Get items by category
                var itemsByCategory = groceryStore.Inventory.GetItemsByCategory();

                // Display items
                foreach (var category in itemsByCategory)
                {
                    inventoryListBox.Items.Add($"Category: {category.Key}");

                    foreach (var item in category.Value)
                    {
                        inventoryListBox.Items.Add($"Name: {item.Name}, Price: {item.Price}, Quantity: {item.Quantity}");
                    }
                }
            }
        }
    }
}
}

