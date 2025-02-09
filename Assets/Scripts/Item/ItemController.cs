using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController
{
    private ItemView itemView;
    private ItemModel itemModel;

    public ItemController(ItemModel itemModel, ItemView itemView)
    {
        this.itemModel = itemModel;
        this.itemView = itemView;

    }

    public List<ItemScriptableObject> GetItemByItemType(ItemType itemType)
    {
        return itemModel.GetScriptableObjects().FindAll(item => item.Type == itemType);
    }

    public void DisplayItem(ItemType itemType, GameObject itemPrefab, Transform itemTransform)
    {
        List<ItemScriptableObject> filterItems = GetItemByItemType(itemType);
        itemView.DisplayItems(filterItems, itemPrefab, itemTransform);
    }
}
