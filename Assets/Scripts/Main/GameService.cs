using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameservice : MonoBehaviour
{
    [SerializeField] private ShopItemScriptableObjectList shopItems;
    [SerializeField] private ShopView shopView;
    [SerializeField] private List<ItemScriptableObject> items;
    [SerializeField] private ItemView itemView;

    private void Start()
    {
        createService();
    }


    private void createService()
    {
        
        ItemService itemService = new ItemService(items, itemView);
        ShopService shopService = new ShopService(shopItems, shopView,itemService.itemController);
    }
}
