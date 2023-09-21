using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;
    public List<Item> Items = new List<Item>();

    public Transform ItemContent;
    public GameObject ItemPrefab; // ItemBtn프리팹

    // 싱글톤 패턴
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
        // 열기 전에 지우기
        /*foreach (Transform item in ItemContent)
        {
            item.gameObject.SetActive(false);
            //Destroy(item.gameObject);
        }*/

        foreach (var item in Items)
        {
            GameObject obj = Instantiate(ItemPrefab, ItemContent); // 프리팹, 위치
            var itemIcon = obj.transform.Find("ItemIcon").GetComponent<Image>();
            itemIcon.sprite = item.icon;

            var itemBtnScript = obj.GetComponent<ItemIconBtn>();
            itemBtnScript.SetItem(item); //  아이템 정보 전달
        }
    }

    public void OnClickItemIcon()
    {

        

    }
}
