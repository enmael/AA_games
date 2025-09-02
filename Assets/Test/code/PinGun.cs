/*
    생성일자 : 2025.09.03
    파일이름 : PinGun.cs
    생성자:
    내용: 스페이스 를 누르면 핀이 발사되는 코드 
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinGun : MonoBehaviour
{
    [SerializeField] Transform startingPosition;
    [SerializeField] GameObject pin;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(pin, startingPosition.position, Quaternion.identity);
        }
    }
}
