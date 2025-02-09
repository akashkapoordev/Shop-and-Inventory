using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopController
{
    private ShopModel shopModel;
    private ShopView shopView;
    private ItemController itemController;

    public ShopController(ShopModel shopModel, ShopView shopView,ItemController itemController)
    {
        this.shopModel = shopModel;
        this.shopView = shopView;
        this.itemController = itemController;

        EventService.Instance.OnItemChange.AddListener(DisplayItems);

        DisplayItems(ItemType.Materials);
    }

    ~ShopController()
    {
        EventService.Instance.OnItemChange.RemoveListener(DisplayItems);

    }

    public void DisplayItems(ItemType itemType)
    {
        itemController.DisplayItem(itemType, shopView.itemPrefab, shopView.itemTransform);
    }
}
