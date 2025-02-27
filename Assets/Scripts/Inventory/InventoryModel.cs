using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryModel 
{
    private List<ItemModel> inventoryItems;

    public InventoryModel()
    {
        inventoryItems = new List<ItemModel>();
    }


    public List<ItemModel> GetInventoryItems()
    {
        return inventoryItems;
    }
}
