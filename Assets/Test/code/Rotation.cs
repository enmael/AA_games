/*
    생성일자 : 2025.09.03
    파일이름 : Rotation.cs
    생성자:
    내용: 제 자리에서 원을 빙글 빙글 돌리는 코드 
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float speed = 100f;

    void Update()
    {
        transform.Rotate(0, 0, speed * Time.deltaTime);
    }
}
