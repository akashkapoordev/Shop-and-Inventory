using System.Collections.Generic;

public class ShopService : GenericMonoSingleton<ShopService>
{

    public ShopService(List<ItemScriptableObject> items, ShopView shopView)
    {
        ShopModel shopModel = new ShopModel(items);
        ShopController shopController = new ShopController(shopModel, shopView);

    }

}
