using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBuy : MonoBehaviour
{
    public Item Item;

    void Buy()
    {
        InventoryManager.Instance.Add(Item);
    }

    private void OnclickItem()
    {
        Buy();
    }
}
