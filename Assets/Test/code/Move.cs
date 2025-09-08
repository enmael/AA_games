/*
    생성일자 : 2025.09.09
    파일이름 : Move.cs
    생성자:
    내용: 맵이 0.1초마다 0.1 x좌표 이동 하는 코드이다 
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float moveAmount = 0.1f; // 한 번에 이동할 거리
    [SerializeField] float interval = 0.1f;   // 이동 간격 (초)

    void Start()
    {
        StartCoroutine(MoveRoutine());
    }

    IEnumerator MoveRoutine()
    {
        while (true)
        {
            // 현재 위치에서 X축으로 moveAmount만큼 이동
            transform.position = new Vector2(transform.position.x + moveAmount, transform.position.y);

            yield return new WaitForSeconds(interval);
        }
    }
    
}
