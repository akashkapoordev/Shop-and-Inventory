using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController 
{
    private InventoryModel inventoryModel;
    private InventoryView inventoryView;


    public InventoryController(InventoryModel inventoryModel, InventoryView inventoryView)
    {
        this.inventoryModel = inventoryModel;
        this.inventoryView = inventoryView;
    }


    public void Additem(ItemModel item)
    {
        inventoryModel.GetInventoryItems().Add(item);
    }


    public void Removeitem(ItemModel item)
    {
        inventoryModel.GetInventoryItems().Remove(item);
    }

    public void Sellitem(ItemModel item)
    {
        Removeitem(item);
    }
}
