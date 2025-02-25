using System.Collections.Generic;
using UnityEngine;

public class ServiceLocator : MonoBehaviour
{
    public static ServiceLocator Instance;

    public List<ItemScriptableObject> items;
    public ShopView shopView;

    public ItemService itemService { get; private set; }
    public ShopService shopService { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            InitializeServices();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void InitializeServices()
    {
        shopService = new ShopService(items, shopView);
    }
}
