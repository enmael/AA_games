using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    [SerializeField] BackgroundManager backgroundManager; 
    private float moveX = 0;
    private float moveY = 0;
    private float interval = 0;

    void Start()
    {
        StartCoroutine(MoveRoutine());
    }

    IEnumerator MoveRoutine()
    {
        while (true)
        {
            moveX = backgroundManager.moveX;
            moveY = backgroundManager.moveY;
            interval = backgroundManager.interval; 
            
            transform.position = new Vector2(transform.position.x + moveX,transform.position.y + moveY);

            yield return new WaitForSeconds(interval);
        }
    }
}
