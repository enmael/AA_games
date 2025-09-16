/*
    생성일자 : 2025.09.16
    파일이름 : PinMachineGun.cs
    생성자:
    내용: 지정한 발사체를 발사하는 코드 
    - 발사체를 재활용하는 코드를 따로 만들어야한다.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinMachineGun : MonoBehaviour
{
    //public PuzzlManager puzzlManager;
    [SerializeField] Transform startingPosition; //pin 발사되는 위치
    [SerializeField] GameObject pin; // 발사체

    //[SerializeField] int number = 0;//PuzzlManager.Score


    void Update()
    {
       // number = puzzlManager.Score;
        if (Input.GetKeyDown(KeyCode.Space)) //스페이스 키 누르면 발사 
        {
            Instantiate(pin, startingPosition.position, Quaternion.identity);
        }
    }
}
