using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemView : MonoBehaviour
{
    private ItemController itemController;

    public void SetConroller(ItemController itemController)
    {
        this.itemController = itemController;
    }
    public void DisplayItems(List<ItemScriptableObject> items,GameObject itemPrefab,Transform itemTransform)
    {
        foreach (Transform child in itemTransform)
        {
            Destroy(child.gameObject);
        }
        foreach (var item in items)
        {
            GameObject itemObject = Instantiate(itemPrefab, itemTransform);
            itemObject.GetComponent<Image>().sprite = item.Icon;
        }

    }
}
