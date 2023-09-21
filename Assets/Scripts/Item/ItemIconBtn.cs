using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemIconBtn : MonoBehaviour
{
    public void ClickItemIconBtn()
    {
        Debug.Log("클릭3");
        InventoryManager.Instance.OnClickItemIcon();
        Debug.Log("클릭4");
    }
}
