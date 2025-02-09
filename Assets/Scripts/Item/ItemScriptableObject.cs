using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public enum ItemType
{
    Materials,
    Weapons,
    Consumables,
    Treasure
}

public enum RarityType
{
    VeryCommon,
    Common,
    Rare,
    Epic,
    Legendary
}

[CreateAssetMenu (fileName = "ItemScriptableObject",menuName ="ItemScriptableObject")]
public class ItemScriptableObject : ScriptableObject
{
    public ItemType Type;
    public Sprite Icon;
    public string ItemDescription;
    public int buyingPrice;
    public int sellingPrice;
    public int weight;
    public int rarity;
    public int Quantity;
}
