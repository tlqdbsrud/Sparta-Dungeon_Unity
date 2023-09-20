using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MenuBtn : MonoBehaviour
{
    public Button[] menuBtn;
    public GameObject[] menuCanvas;

    private void Awake()
    {
        menuCanvas[0].gameObject.SetActive(false); // 시작 때 캐릭터 정보 내용 비활성화
        menuCanvas[1].gameObject.SetActive(false); // 시작 때 내 아이템 비활성화
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < menuBtn.Length; i++)
        {
            int buttonIndex = i;
            menuBtn[i].onClick.AddListener(() => OnMenuButtonClick(buttonIndex)); // 버튼 클릭 
        }
    }

    private void OnMenuButtonClick(int menuIndex)
    {
        if(menuIndex == 0) // 캐릭터 정보 버튼
        {
            menuCanvas[0].gameObject.SetActive(true); // 캐릭터 정보 내용 활성화
            
            // 3개 메뉴 버튼 비활성화
            if (menuCanvas[0].activeSelf)
            {
                menuBtn[0].gameObject.SetActive(false);
                menuBtn[2].gameObject.SetActive(false);
                menuBtn[4].gameObject.SetActive(false);
            }
        }
        else if(menuIndex == 1) // 뒤로가기 버튼
        {
            menuCanvas[0].gameObject.SetActive(false); // 캐릭터 정보 내용 비활성화

            // 3개 메뉴 버튼 활성화
            if (!menuCanvas[0].activeSelf)
            {
                menuBtn[0].gameObject.SetActive(true);
                menuBtn[2].gameObject.SetActive(true);
                menuBtn[4].gameObject.SetActive(true);
            }
        }
        else if(menuIndex == 2) // 내 아이템(인벤토리)
        {
            menuCanvas[1].gameObject.SetActive(true); // 내 아이템(인벤토리) 활성화
        }
        else if (menuIndex == 3) // 내 아이템(인벤토리)
        {
            menuCanvas[1].gameObject.SetActive(false); // 내 아이템(인벤토리) 활성화
        }
    }
}
