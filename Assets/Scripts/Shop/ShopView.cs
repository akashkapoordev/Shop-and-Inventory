using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ShopView : MonoBehaviour
{
    public GameObject itemPrefab;
    public Transform itemTransform;
    [SerializeField] Button materialButton;
    [SerializeField] Button weaponButton;
    [SerializeField] Button consumablesButton;
    [SerializeField] Button treasureButton;

    private void OnEnable()
    {
        materialButton.onClick.AddListener(() => EventService.Instance.OnItemChange.InvokeEvent(ItemType.Materials));
        weaponButton.onClick.AddListener(() => EventService.Instance.OnItemChange.InvokeEvent(ItemType.Weapons));
        consumablesButton.onClick.AddListener(() => EventService.Instance.OnItemChange.InvokeEvent(ItemType.Consumables));
        treasureButton.onClick.AddListener(() => EventService.Instance.OnItemChange.InvokeEvent(ItemType.Treasure));
    }
    private void Start()
    {
        
    }
    //public void DisplayItems(List<ItemScriptableObject> items)
    //{
    //    foreach (Transform child in itemTransform)
    //    {
    //        Destroy(child.gameObject);
    //    }
    //    foreach (var item in items)
    //    {
    //        GameObject itemObject = Instantiate(itemPrefab,itemTransform);
    //        itemObject.GetComponent<Image>().sprite = item.Icon;
    //    }

    //}
}
