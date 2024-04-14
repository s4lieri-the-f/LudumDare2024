[System.Serializable]
public class InventoryItem
{
    public string itemName;
    public int quantity;
    public int maxQuantity;

    public InventoryItem(string itemName, int quantity, int maxQuantity)
    {
        this.itemName = itemName;
        this.quantity = quantity;
        this.maxQuantity = maxQuantity;
    }
}