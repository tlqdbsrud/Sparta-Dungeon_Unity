using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Defense : Stat
{
    private void Start()
    {
        StatManager.instance.UpdateDefenseText(defense);
    }
}
