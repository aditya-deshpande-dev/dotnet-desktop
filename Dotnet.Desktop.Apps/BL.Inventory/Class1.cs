namespace BL.Inventory
{
    public class Inventory
    {
        public List<InventoryItem> items { get; set; }

        public Inventory()
        {
            items = new List<InventoryItem>();
            FillInventoryWithDefault();
        }

        public void FillInventoryWithDefault()
        {
            items.Add(new InventoryItem { id = 1, name = "Bread", description = "Samrat White Bread", purchaseValue = 24.00, sellValue = 30.00, unit = 15 });
            items.Add(new InventoryItem { id = 2, name = "Milk", description = "Amul Cow Milk 0.5L", purchaseValue = 24.00, sellValue = 26.00, unit = 20 });
            items.Add(new InventoryItem { id = 3, name = "Butter", description = "Amul 220gm", purchaseValue = 40.00, sellValue = 45.00, unit = 10 });
        }

        public void AddItem(InventoryItem item)
        {
            var invItem = items.FirstOrDefault(x => x.id == item.id);
            if (invItem != null)
            {
                invItem.unit += 1;
            }
            else
            {
                items.Add(item);
            }
        }
    }

    public class InventoryItem
    {
        public int id { get; set; }
        public string name { get; set; }
        public int unit { get; set; }
        public string description { get; set; }
        public double purchaseValue { get; set; }
        public double sellValue { get; set; }
    }
}