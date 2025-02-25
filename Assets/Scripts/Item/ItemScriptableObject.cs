using UnityEngine;

public enum ItemType
{
    Materials,
    Weapons,
    Consumables,
    Treasure
}

public enum RarityType
{
    VeryCommon,
    Common,
    Rare,
    Epic,
    Legendary
}

[CreateAssetMenu(fileName = "Item", menuName = "Shop/Item")]
public class ItemScriptableObject : ScriptableObject
{
    public string itemName;
    public string itemDescription;
    public int buyingPrice;
    public int sellingPrice;
    public int quantity;
    public ItemType itemType;
    public RarityType rarity;
    public Sprite icon;
}
