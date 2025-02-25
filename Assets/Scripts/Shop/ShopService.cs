using System.Collections.Generic;

public class ShopService
{

    public ShopService(List<ItemScriptableObject> items, ShopView shopView)
    {
        ShopModel shopModel = new ShopModel(items);
        ShopController shopController = new ShopController(shopModel, shopView);

    }
}
