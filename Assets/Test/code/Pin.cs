/*
    생성일자 : 2025.09.03
    파일이름 : Pin.cs
    생성자:
    내용: 핀을 날리는 코드 
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    [SerializeField] float speed = 10f;

    private bool isPined = false;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (isPined == false)
        {
            transform.position += Vector3.up * speed * Time.deltaTime;    
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {// 왜 istriggr를 체크 하지 않은거야 
        isPined = true;
        //충돌하면 오브젝트의 자식으로

        if (collision.gameObject.tag == "Center")
        {
            transform.SetParent(collision.gameObject.transform);
        }
        // else if (collision.gameObject.tag == "PinHead")
        // {
        //     rb.gravityScale += 1f;
        // }
    }

}
