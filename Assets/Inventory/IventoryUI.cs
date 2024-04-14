public class InventoryUI : MonoBehaviour
{
    public InventoryManager inventoryManager;
    public void UpdateUI()
    {
        
        ClearUI();

        
        foreach (InventoryItem item in inventoryManager.items)
        {
            
            GameObject itemUI = new GameObject();
            itemUI.transform.SetParent(transform);
            
            Text text = itemUI.AddComponent<Text>();
            text.text = item.itemName + " x" + item.quantity;
        }
    }

    public void OnItemClicked()
    {
        // Пока что нихуя, надо докрутить
    }
}