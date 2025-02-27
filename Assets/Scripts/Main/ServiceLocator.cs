using System.Collections.Generic;
using UnityEngine;

public class ServiceLocator : GenericMonoSingleton<ServiceLocator>
{

    public List<ItemScriptableObject> items;
    public ShopView shopView;

    public ItemService itemService { get; private set; }
    public ShopService shopService { get; private set; }
    public EventService eventService { get; private set; }

    private void Start()
    {
 
            InitializeServices();
      
    }

    private void InitializeServices()
    {
        eventService = new EventService();
        shopService = new ShopService(items, shopView);
    }
}
