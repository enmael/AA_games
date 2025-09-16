/*
    생성일자 : 2025.09.15
    파일이름 : UiManger.cs
    생성자:
    내용: 시작 ui를 관리하는 코드이다.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManger : MonoBehaviour
{

    [SerializeField] GameObject UiObject;
    [SerializeField] Button startButton;
    [SerializeField] Button settingsButton;
    [SerializeField] Button creditsButton;

    //[SerializeField] public bool gameStart = false;

    // public bool GameStart
    // {
    //     get { return gameStart; }
    // }

    void Start()
    {
        startButton.onClick.AddListener(OnStartClicked);
        settingsButton.onClick.AddListener(OnSettingsClicked);
        creditsButton.onClick.AddListener(OnCreditsClicked);
    }

    void OnStartClicked()
    {
        UiObject.SetActive(false); 
        //gameStart = true;
    }

    void OnSettingsClicked()
    {
        Debug.Log("설정 창 열기");
        // 설정 UI를 활성화하거나 다른 씬/패널 띄우기
    }

    void OnCreditsClicked()
    {
        Debug.Log("제작진 확인 창 열기");
        // 크레딧 UI 띄우거나 다른 씬 이동
    }
}
