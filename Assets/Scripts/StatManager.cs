using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StatManager : MonoBehaviour
{
    public TMP_Text attackTxt;
    public TMP_Text defenseTxt;
    public TMP_Text expTxt;
    public Slider expBar;
    public TMP_Text goldTxt;
   

    // UI Manager �̱��� ����
    public static StatManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // attack �ؽ�Ʈ ������Ʈ
    public void UpdateAttackText(int attackValue)
    {
        //attackTxt = GetComponent<TMP_Text>();
        attackTxt.text = attackValue.ToString();
    }

    // ���� �ؽ�Ʈ ������Ʈ
    public void UpdateDefenseText(int defenseValue)
    {
        defenseTxt.text = defenseValue.ToString();
    }

    // exp �����̴� ������Ʈ
    public void UpdateExpSlider(int expValue, int maxExpValue)
    {
        expBar.value = (float)expValue / maxExpValue;
    }

    // ��� �ؽ�Ʈ ������Ʈ
    public void UpdateGoldText(int goldValue)
    {
        goldTxt.text = string.Format("{0:#,###}", goldValue);
    }

   
}
