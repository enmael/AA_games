/*
    생성일자 : 2025.09.16
    파일이름 : ScoreManager.cs
    생성자:
    내용: 점수를 판정하는코드이다 
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public PuzzlManager puzzlManager;

    [SerializeField] int score = 0;
    [SerializeField] GameObject mainGameObject;

    public int childCount = 0;
    void Start()
    {
        StartCoroutine(ClearScoreUpdate());
        StartCoroutine(CheckChildRoutine());
        StartCoroutine(CheckYourScore());
    }

    //클리어해야 되는 점수를 업데이트 하는 코드
    IEnumerator ClearScoreUpdate() 
    {
        while (true)
        {
            score = puzzlManager.Score;
            yield return new WaitForSeconds(1);
        }
    }

    //퍼즐 오브젝트에 자식이 추가되었는지 판단하는 코드
    IEnumerator CheckChildRoutine()
    {
        while (true)
        {
            int currentChildCount = mainGameObject.transform.childCount;

            if (currentChildCount != childCount)
            {
                if (currentChildCount > childCount)
                {
                    Debug.Log("자식 추가됨!");
                }
                else
                {
                    Debug.Log("자식 제거됨!");
                }

                childCount = currentChildCount;
            }

            yield return new WaitForSeconds(0.1f); // 0.1초마다 체크
        }
    }

    // 클리어 판정하는 코드
    IEnumerator CheckYourScore()
    {
        while (true)
        {
            if (score == childCount && childCount>0)
            {
                Debug.Log("클리어");
            }
            else
            {
                Debug.Log("클리어되지 못함");
            }
            yield return new WaitForSeconds(0.1f); // 0.1초마다 체크
        }
    }
    
}
