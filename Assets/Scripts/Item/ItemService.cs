using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemService 
{
    private List<ItemScriptableObject> itemScriptableObjects;
    private ItemView itemView;
    public ItemController itemController { get; private set; }
    public ItemService(List<ItemScriptableObject> itemScriptableObjects, ItemView itemView)
    {
        this.itemScriptableObjects = itemScriptableObjects;
        this.itemView = itemView;
        initializeVariables();
    }


    private void  initializeVariables()
    {
        ItemModel itemModel = new ItemModel(itemScriptableObjects);
         itemController = new ItemController(itemModel, itemView);
    }


}
