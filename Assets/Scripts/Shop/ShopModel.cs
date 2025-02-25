using System.Collections.Generic;

public class ShopModel
{
    private List<ItemScriptableObject> availableItems;

    public ShopModel(List<ItemScriptableObject> availableItems)
    {
        this.availableItems = availableItems;
    }

    public List<ItemScriptableObject> GetItemsByType(ItemType itemType)
    {
        return availableItems.FindAll(item => item.itemType == itemType);
    }

    public ItemScriptableObject GetItemByName(string itemName)
    {
        return availableItems.Find(item => item.itemName == itemName);
    }
}
