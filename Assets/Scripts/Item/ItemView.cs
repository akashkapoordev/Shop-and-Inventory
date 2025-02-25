using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ItemView : MonoBehaviour
{
    public TextMeshProUGUI itemNameText;
    public TextMeshProUGUI descriptionText;
    public TextMeshProUGUI priceText;
    public TextMeshProUGUI quantityText;
    public Image itemIcon;

    public void DisplayItemDetails(ItemModel item)
    {
        //itemNameText.text = item.ItemName;
        //descriptionText.text = item.ItemDescription;
        //priceText.text = $"Price: {item.BuyingPrice}";
        //quantityText.text = $"Quantity: {item.Quantity}";
        itemIcon.sprite = item.Icon;
    }

    public void UpdateQuantity(int quantity)
    {
        quantityText.text = $"Quantity: {quantity}";
    }

}
