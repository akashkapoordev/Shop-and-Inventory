using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;


public class ShopView : MonoBehaviour
{
    public Transform itemListPanel; 
    public GameObject itemPrefab;
    public GameObject panelItem;
     ItemView itemView;   


    public void DisplayItems(List<ItemModel> items)
    { 


        foreach (Transform child in itemListPanel)
        {
            Destroy(child.gameObject); 
        }

        foreach (var item in items)
        {
            GameObject itemObject = Instantiate(itemPrefab, itemListPanel);  
            itemObject.GetComponentInChildren<TextMeshProUGUI>().text = item.Quantity.ToString();  
            itemObject.transform.GetChild(0).GetChild(0).GetComponent<Image>().sprite = item.Icon;


            Button itemButton = itemObject.GetComponent<Button>();
            itemView = itemObject.GetComponent<ItemView>();
            itemButton.onClick.AddListener(() => OnItemSelected(item));
        }
    }


    public void OnItemSelected(ItemModel item)
    {
        panelItem.SetActive(true);
        ItemView panelListItem = panelItem.GetComponent<ItemView>();

        panelListItem.DisplayItemDetails(item);
    }
}
