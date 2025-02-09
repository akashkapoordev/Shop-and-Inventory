using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopService 
{
    [SerializeField]private ShopItemScriptableObjectList shopItemScriptableObject;
    [SerializeField]private ShopView shopView;


    public ShopService(ShopItemScriptableObjectList shopItemScriptableObjectList,ShopView shopView)
    {
        this.shopItemScriptableObject = shopItemScriptableObjectList;
        this.shopView = shopView;
        initializeVariables();
    }


    private void  initializeVariables()
    {
        ShopModel shopModel = new ShopModel(shopItemScriptableObject);
        ShopController shopController = new ShopController(shopModel,shopView); 
    }
    
}
