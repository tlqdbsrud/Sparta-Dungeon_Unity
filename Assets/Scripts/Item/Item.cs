using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Attack,
    Defense,
}

[CreateAssetMenu(fileName = "New Item", menuName = "Item/Create New Item")]
public class Item : ScriptableObject
{
    public string itemName;
    public ItemType itemtype;
    public int attack;
    public int defense;
    public string aboutItem;
    public Sprite icon;

}
