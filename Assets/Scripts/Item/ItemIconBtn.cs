using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemIconBtn : MonoBehaviour
{
    public Button itemBtn; 
    public GameObject equip;
    private bool isEquip = false;
    private Item item;

    private void Awake()
    {
        equip.gameObject.SetActive(false);
    }

    private void Start()
    {
        itemBtn.onClick.AddListener(ClickItemIconBtn);
    }

    public void SetItem(Item newItem)
    {
        item = newItem; // 아이템 정보를 설정
    }

    public void ClickItemIconBtn()
    {
        if (item != null) // 아이템이 null이 아닌 경우에만 처리
        {
            if (!isEquip)
            {
                equip.gameObject.SetActive(true);
                isEquip = true;

                if (item.itemType == ItemType.Attack)
                {
                    Debug.Log("공격");
                    StatManager.instance.UpdateAttackText(StatManager.instance.attack + item.attack);
                }
                else if (item.itemType == ItemType.Defense)
                {
                    Debug.Log("방어");
                    StatManager.instance.UpdateDefenseText(StatManager.instance.defense + item.defense);
                }

            }
            else
            {
                equip.gameObject.SetActive(false);
                isEquip = false;

                if (item.itemType == ItemType.Attack)
                {
                    StatManager.instance.UpdateAttackText(StatManager.instance.attack - item.attack);
                }
                else if (item.itemType == ItemType.Defense)
                {
                    StatManager.instance.UpdateDefenseText(StatManager.instance.defense - item.defense);
                }
            }
        }
           
    }
}
