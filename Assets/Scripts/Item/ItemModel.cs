using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemModel
{
    private List<ItemScriptableObject> itemScriptableObjects;

    public ItemModel(List<ItemScriptableObject> scriptableObjects)
    {
        itemScriptableObjects = scriptableObjects;
    }

    public List<ItemScriptableObject> GetScriptableObjects()
    {
        return itemScriptableObjects;
    }
}
