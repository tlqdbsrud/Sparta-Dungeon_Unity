using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemIconBtn : MonoBehaviour
{
    public void ClickItemIconBtn()
    {
        Debug.Log("Ŭ��3");
        InventoryManager.Instance.OnClickItemIcon();
        Debug.Log("Ŭ��4");
    }
}
