using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopController
{
    private ShopModel shopModel;
    private ShopView shopView;

    public ShopController(ShopModel shopModel, ShopView shopView)
    {
        this.shopModel = shopModel;
        this.shopView = shopView;

        EventService.Instance.OnItemChange.AddListener(DisplayItems);

        DisplayItems(ItemType.Materials);
    }

    ~ShopController()
    {
        EventService.Instance.OnItemChange.RemoveListener(DisplayItems);

    }

    public void DisplayItems(ItemType itemType)
    {
        List<ItemScriptableObject> filterItems = shopModel.GetItemByType(itemType);
        shopView.DisplayItems(filterItems);
    }
}
