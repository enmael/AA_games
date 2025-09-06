/*
    생성일자 : 2025.09.07
    파일이름 : WoodCounter.cs
    생성자:
    내용: 행성 오브젝트에 자식이 추가 되는지 안되는지 를 확인하고 값을 넘기는 코드  
*/

using System.Collections;
using UnityEngine;

public class WoodCounter : MonoBehaviour
{
    public int childCount = 0;
    [SerializeField] GameObject mainGameObject;

    public int WoodCounterReturn
    {
        get { return childCount; }
         
    }

    void Start()
    {
        childCount = mainGameObject.transform.childCount;
        StartCoroutine(CheckChildRoutine());
    }

    IEnumerator CheckChildRoutine()
    {
        while (true)
        {
            int currentChildCount = mainGameObject.transform.childCount;

            if (currentChildCount != childCount)
            {
                if (currentChildCount > childCount)
                    Debug.Log("자식 추가됨!");
                else
                    Debug.Log("자식 제거됨!");

                childCount = currentChildCount; 
            }

            yield return new WaitForSeconds(0.1f); // 0.1초마다 체크
        }
    }
}
