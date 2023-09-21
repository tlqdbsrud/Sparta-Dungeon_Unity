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
        item = newItem; // ������ ������ ����
    }

    public void ClickItemIconBtn()
    {
        if (item != null) // �������� null�� �ƴ� ��쿡�� ó��
        {
            if (!isEquip)
            {
                equip.gameObject.SetActive(true);
                isEquip = true;

                if (item.itemType == ItemType.Attack)
                {
                    Debug.Log("����");
                    StatManager.instance.UpdateAttackText(StatManager.instance.attack + item.attack);
                }
                else if (item.itemType == ItemType.Defense)
                {
                    Debug.Log("���");
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
