/*
    생성일자 : 2025.09.09
    파일이름 : SpaceBlockManagement.cs
    생성자:
    내용: 코루틴을 이용해서 맵을 반복 처리하는 코드이다.
*/
using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEditor;
using UnityEngine;

public class SpaceBlockManagement : MonoBehaviour
{

    [SerializeField] List<GameObject> spaceBlockList;

    void Start()
    {
        spaceBlockList.Capacity = 20;

        StartCoroutine(MyCoroutine());
    }
IEnumerator MyCoroutine()
    {
        while (true) // 무한 반복
        {
            for (int i = 0; i < spaceBlockList.Count; i++)
            {
                Vector2 pos = spaceBlockList[i].transform.position;

                if (pos.x >= 20) { pos.x = -20; }
                if (pos.y >= 20) { pos.y = -20; }

                spaceBlockList[i].transform.position = pos;
            }

            yield return new WaitForSeconds(0.1f); // 0.1초 대기
        }
    }
}
