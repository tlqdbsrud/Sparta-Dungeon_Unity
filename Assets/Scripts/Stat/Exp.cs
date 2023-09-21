using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Exp : Stat
{
    private void Start()
    {
        StatManager.instance.UpdateExpSlider(exp, maxExp);
    }
}
