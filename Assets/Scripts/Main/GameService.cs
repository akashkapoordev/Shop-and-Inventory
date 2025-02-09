using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameservice : MonoBehaviour
{
    [SerializeField] ShopItemScriptableObjectList shopItems;
    [SerializeField] ShopView shopView;

    private void Start()
    {
        createService();
    }


    private void createService()
    {
        ShopService shopService = new ShopService(shopItems, shopView);
    }
}
