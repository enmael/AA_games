/*
    생성일자 : 2025.09.15
    파일이름 : BackgroundManager.cs
    생성자:
    내용: BackgroundMove에값을 조정하는 코드이다.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundManager : MonoBehaviour
{
    [SerializeField]public float moveX;
    [SerializeField]public float moveY;
    [SerializeField]public float interval;

    public float Move_X
    {
        get { return moveX; }
    }

    public float Move_Y
    {
        get { return moveY; }
    }
    
    public float Interval
    {
        get { return interval; }
    }
}
