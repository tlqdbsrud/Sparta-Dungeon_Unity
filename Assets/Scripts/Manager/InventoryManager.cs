using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;
    public List<Item> Items = new List<Item>();

    public Transform ItemContent;
    public GameObject ItemPrefab; // ItemBtn������

    // �̱��� ����
    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        ListItems();
    }

    public void Add(Item item)
    {
        Items.Add(item);
    }

    public void Remove(Item item)
    {
        Items.Remove(item);
    }

    public void ListItems()
    {
        // ���� ���� �����
        /*foreach (Transform item in ItemContent)
        {
            item.gameObject.SetActive(false);
            //Destroy(item.gameObject);
        }*/

        foreach (var item in Items)
        {
            GameObject obj = Instantiate(ItemPrefab, ItemContent); // ������, ��ġ
            var itemIcon = obj.transform.Find("ItemIcon").GetComponent<Image>();
            itemIcon.sprite = item.icon;

            var itemBtnScript = obj.GetComponent<ItemIconBtn>();
            itemBtnScript.SetItem(item); //  ������ ���� ����
        }
    }

    public void OnClickItemIcon()
    {

        

    }
}
