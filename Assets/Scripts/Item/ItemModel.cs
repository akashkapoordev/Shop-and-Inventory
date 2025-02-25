using UnityEngine;

public class ItemModel
{
    private ItemScriptableObject itemScriptableObject;

    public ItemModel(ItemScriptableObject itemScriptableObject)
    {
        this.itemScriptableObject = itemScriptableObject;
    }

    public ItemScriptableObject GetScriptableObject()
    {
        return itemScriptableObject;
    }

    public string ItemName => itemScriptableObject.itemName;
    public string ItemDescription => itemScriptableObject.itemDescription;
    public int BuyingPrice => itemScriptableObject.buyingPrice;
    public int SellingPrice => itemScriptableObject.sellingPrice;
    public int Quantity
    {
        get => itemScriptableObject.quantity;
        set => itemScriptableObject.quantity = Mathf.Max(0, value);
    }
    public ItemType ItemType => itemScriptableObject.itemType;
    public RarityType Rarity => itemScriptableObject.rarity;
    public Sprite Icon => itemScriptableObject.icon;
}
