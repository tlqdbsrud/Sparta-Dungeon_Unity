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
        menuCanvas[0].gameObject.SetActive(false); // ���� �� ĳ���� ���� ���� ��Ȱ��ȭ
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
            menuBtn[i].onClick.AddListener(() => OnMenuButtonClick(buttonIndex)); // ��ư Ŭ�� 
        }
    }

    private void OnMenuButtonClick(int menuIndex)
    {
        if(menuIndex == 0)
        {
            menuCanvas[0].gameObject.SetActive(true); // ĳ���� ���� ���� Ȱ��ȭ
            if (menuCanvas[0].activeSelf)
            {
                menuBtn[0].gameObject.SetActive(false);
                menuBtn[2].gameObject.SetActive(false);
                menuBtn[3].gameObject.SetActive(false);
            }
        }
        else if(menuIndex == 1)
        {
            menuCanvas[0].gameObject.SetActive(false);
            if (!menuCanvas[0].activeSelf)
            {
                menuBtn[0].gameObject.SetActive(true);
                menuBtn[2].gameObject.SetActive(true);
                menuBtn[3].gameObject.SetActive(true);
            }
        }
        else if(menuIndex == 2)
        {

        }
    }
}
