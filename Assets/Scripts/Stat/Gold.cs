using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Gold : Stat
{

    private void Start()
    {
        StatManager.instance.UpdateGoldText(gold);
    }
}
