using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopService 
{
        private ShopItemScriptableObjectList shopItemScriptableObject;
        private ShopView shopView;
        private ItemController itemController;


    public ShopService(ShopItemScriptableObjectList shopItemScriptableObjectList,ShopView shopView,ItemController itemController)
    {
        this.itemController = itemController;
        this.shopItemScriptableObject = shopItemScriptableObjectList;
        this.shopView = shopView;
        initializeVariables();
    }


    private void  initializeVariables()
    {
        ShopModel shopModel = new ShopModel(shopItemScriptableObject);
        ShopController shopController = new ShopController(shopModel,shopView,itemController); 
    }
    
}
