using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName ="ShopSOList",menuName ="ShopSOList")]
public class ShopItemScriptableObjectList : ScriptableObject
{
    public List<ItemScriptableObject> shopItems;
}
