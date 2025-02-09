using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopModel
{
    private ShopItemScriptableObjectList shopItems;

    public ShopModel(ShopItemScriptableObjectList shopItems)
    {
        this.shopItems = shopItems;
    }

    public List<ItemScriptableObject> GetItemByType(ItemType itemType)
    {
        return shopItems.shopItems.FindAll(item => item.Type == itemType);
    }
}
