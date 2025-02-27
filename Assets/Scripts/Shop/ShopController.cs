using UnityEngine;
using System.Collections.Generic;

public class ShopController
{
    private ShopView shopView;
    private ShopModel shopModel;
    private ItemController itemController;

    public ShopController(ShopModel shopModel, ShopView shopView)
    {
        this.shopModel = shopModel;
        this.shopView = shopView;

        DisplayShopItems(ItemType.Weapons);

        ServiceLocator.Instance.eventService.OnItemChange.AddListener(DisplayShopItems);
    }
    

    public void DisplayShopItems(ItemType itemType)
    {
        var items = shopModel.GetItemsByType(itemType);
        var itemModels = new List<ItemModel>();

        foreach (var item in items)
        {
            itemModels.Add(new ItemModel(item));
        }

        shopView.DisplayItems(itemModels);
    }


    ~ShopController()
    {
        ServiceLocator.Instance.eventService.OnItemChange.RemoveListener(DisplayShopItems);
    }




}
