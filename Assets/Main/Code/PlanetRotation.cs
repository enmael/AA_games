/*
    생성일자 : 2025.09.16
    파일이름 : PlanetRotation.cs
    생성자:
    내용: PuzzlManager 에서 지정한 행성 속도로 행성을 회전 시키는 코드 
*/
using System.Collections;
using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    public PuzzlManager puzzlManager; // 인스펙터에서 연결
    private float speed = 0f;

    void Start()
    {
        StartCoroutine(RotateCoroutine());
    }

    IEnumerator RotateCoroutine()
    {
        while (true)
        {
            // 현재 속도 가져오기
            speed = puzzlManager.PlanetSpeed;

            // 회전
            transform.Rotate(0f, 0f, speed * Time.deltaTime);

            // 다음 프레임까지 대기
            //yield return null; // Update처럼 매 프레임 실행
            yield return new WaitForSeconds(0.02f); // 원하는 간격으로 조절 가능
        }
    }
}
