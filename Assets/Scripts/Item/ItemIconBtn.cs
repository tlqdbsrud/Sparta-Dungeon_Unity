using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemIconBtn : MonoBehaviour
{
    public Button itemBtn; 
    public GameObject equip;
    private bool isEquip = false;

    private void Awake()
    {
        equip.gameObject.SetActive(false);
    }

    private void Start()
    {
        itemBtn.onClick.AddListener(ClickItemIconBtn);
    }

    public void ClickItemIconBtn()
    {
        if (!isEquip)
        {
            equip.gameObject.SetActive(true);
            isEquip = true;
            //StatManager.instance.UpdateAttackText(StatManager.instance.attack + );
        }
        else
        {
            equip.gameObject.SetActive(false);
            isEquip = false;
        }
    }
}
