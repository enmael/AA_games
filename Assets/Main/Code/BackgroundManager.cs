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
