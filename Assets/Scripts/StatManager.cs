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
   

    // UI Manager 싱글톤 패턴
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
    // attack 텍스트 업데이트
    public void UpdateAttackText(int attackValue)
    {
        //attackTxt = GetComponent<TMP_Text>();
        attackTxt.text = attackValue.ToString();
    }

    // 방어력 텍스트 업데이트
    public void UpdateDefenseText(int defenseValue)
    {
        defenseTxt.text = defenseValue.ToString();
    }

    // exp 슬라이더 업데이트
    public void UpdateExpSlider(int expValue, int maxExpValue)
    {
        expBar.value = (float)expValue / maxExpValue;
    }

    // 골드 텍스트 업데이트
    public void UpdateGoldText(int goldValue)
    {
        goldTxt.text = string.Format("{0:#,###}", goldValue);
    }

   
}
