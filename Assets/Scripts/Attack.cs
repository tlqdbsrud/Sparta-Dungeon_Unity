using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Attack : Stat
{

    private void Start()
    {
        StatManager.instance.UpdateAttackText(attack);
    }
}
