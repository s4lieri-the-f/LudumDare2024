public class InventoryManager : MonoBehaviour
{
    public List<InventoryItem> items = new List<InventoryItem>();

    public void AddItem(InventoryItem itemToAdd)
    {
        items.Add(itemToAdd);
    }

    public void RemoveItem(InventoryItem itemToRemove)
    {
        items.Remove(itemToRemove);
    }
}