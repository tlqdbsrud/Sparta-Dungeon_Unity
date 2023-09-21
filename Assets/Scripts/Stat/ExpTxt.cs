using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpTxt : Stat
{
    private void Start()
    {
        StatManager.instance.UpdateExpTxt(exp);
    }
}
