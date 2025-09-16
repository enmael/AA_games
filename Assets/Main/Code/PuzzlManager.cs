/*
    생성일자 : 2025.09.16
    파일이름 : PuzzlManager.cs
    생성자:
    내용: 퍼즐에 나오는 오브젝트를 관리하는 코드이다 이짓거리는 안하는걸 추천한다 
        json 을 사용하도록 이건 그냥 내가 귀찮아서 한짓이다 
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using Unity.VisualScripting;
using UnityEngine;

public class PuzzlManager : MonoBehaviour
{
    [SerializeField] int puzzleLevel = 0;
    [SerializeField] bool puzzleClear = true;
    [SerializeField] int score = 0;

    // ui 실행 신호 코드 나중에 추가
    //public UiManger uiManger;

    [SerializeField] GameObject planet;
    [SerializeField] public float planetSpeed = 0;

    [SerializeField] bool test = false;

    public float PlanetSpeed
    {
        get { return planetSpeed; }
    }

    public int Score
    {
        get{ return score; }
    }
    // [SerializeField] GameObject satellite0;

    // [SerializeField] public float satellite0_Speed = 0;

    // [SerializeField] GameObject satellite1;
    // [SerializeField] public float satellite1_Speed = 0;

    // [SerializeField] GameObject satellite2;
    // [SerializeField] public float satellite2_Speed = 0;

    // [SerializeField] GameObject satellite3;
    // [SerializeField] public float satellite3_Speed = 0;

    // [SerializeField] GameObject satellite4;
    // [SerializeField] public float satellite4_Speed = 0;

    void Start()
    {
        StartCoroutine(LeverUp());
    }
    // void Update()
    // {
    //     test = uiManger.gameStart;
    // }

    IEnumerator LeverUp()
    {
        while (true && puzzleClear == true)
        {
            #region 퍼즐
            //0 레벨
            if (puzzleLevel == 0)
            {
                planet.SetActive(true);
                planetSpeed = 100;
                //satellite0.SetActive(false);
                //satellite1.SetActive(false);
                //satellite2.SetActive(false);
                //satellite3.SetActive(false);
                //satellite4.SetActive(false);
                score = 5;
                puzzleClear = false;
            }

            //1 레벨
            if (puzzleLevel == 1)
            {
                //planet.SetActive(true);
                planetSpeed = 100;
                //satellite0.SetActive(false);
                //satellite1.SetActive(false);
                //satellite2.SetActive(false);
                //satellite3.SetActive(false);
                //satellite4.SetActive(false);
                score = 5;
                puzzleClear = false;
            }

            //1 레벨
            if (puzzleLevel == 2)
            {
                //planet.SetActive(true);
                planetSpeed = 1;
                //satellite0.SetActive(false);
                //satellite1.SetActive(false);
                //satellite2.SetActive(false);
                //satellite3.SetActive(false);
                //satellite4.SetActive(false);

                puzzleClear = false;
            }

            //1 레벨
            if (puzzleLevel == 3)
            {
                //planet.SetActive(true);
                planetSpeed = 1;
                //satellite0.SetActive(false);
                //satellite1.SetActive(false);
                //satellite2.SetActive(false);
                //satellite3.SetActive(false);
                //satellite4.SetActive(false);

                puzzleClear = false;
            }

            //1 레벨
            if (puzzleLevel == 4)
            {
                //planet.SetActive(true);
                planetSpeed = 1;
                //satellite0.SetActive(false);
                //satellite1.SetActive(false);
                //satellite2.SetActive(false);
                //satellite3.SetActive(false);
                //satellite4.SetActive(false);

                puzzleClear = false;
            }

            //1 레벨
            if (puzzleLevel == 5)
            {
                //planet.SetActive(true);
                planetSpeed = 1;
                //satellite0.SetActive(false);
                //satellite1.SetActive(false);
                //satellite2.SetActive(false);
                //satellite3.SetActive(false);
                //satellite4.SetActive(false);

                puzzleClear = false;
            }

            //1 레벨
            if (puzzleLevel == 6)
            {
                //planet.SetActive(true);
                planetSpeed = 1;
                //satellite0.SetActive(false);
                //satellite1.SetActive(false);
                //satellite2.SetActive(false);
                //satellite3.SetActive(false);
                //satellite4.SetActive(false);

                puzzleClear = false;
            }

            //1 레벨
            if (puzzleLevel == 7)
            {
                //planet.SetActive(true);
                planetSpeed = 1;
                //satellite0.SetActive(false);
                //satellite1.SetActive(false);
                //satellite2.SetActive(false);
                //satellite3.SetActive(false);
                //satellite4.SetActive(false);

                puzzleClear = false;
            }

            //1 레벨
            if (puzzleLevel == 8)
            {
                //planet.SetActive(true);
                planetSpeed = 1;
                //satellite0.SetActive(false);
                //satellite1.SetActive(false);
                //satellite2.SetActive(false);
                //satellite3.SetActive(false);
                //satellite4.SetActive(false);

                puzzleClear = false;
            }

            //1 레벨
            if (puzzleLevel == 9)
            {
                //planet.SetActive(true);
                planetSpeed = 1;
                //satellite0.SetActive(false);
                //satellite1.SetActive(false);
                //satellite2.SetActive(false);
                //satellite3.SetActive(false);
                //satellite4.SetActive(false);

                puzzleClear = false;
            }

            //1 레벨
            if (puzzleLevel == 10)
            {
                //planet.SetActive(true);
                planetSpeed = 1;
                //satellite0.SetActive(false);
                //satellite1.SetActive(false);
                //satellite2.SetActive(false);
                //satellite3.SetActive(false);
                //satellite4.SetActive(false);

                puzzleClear = false;
            }

            //1 레벨
            if (puzzleLevel == 11)
            {
                //planet.SetActive(true);
                planetSpeed = 1;
                //satellite0.SetActive(false);
                //satellite1.SetActive(false);
                //satellite2.SetActive(false);
                //satellite3.SetActive(false);
                //satellite4.SetActive(false);

                puzzleClear = false;
            }

            //1 레벨
            if (puzzleLevel == 12)
            {
                //planet.SetActive(true);
                planetSpeed = 1;
                //satellite0.SetActive(false);
                //satellite1.SetActive(false);
                //satellite2.SetActive(false);
                //satellite3.SetActive(false);
                //satellite4.SetActive(false);

                puzzleClear = false;
            }

            //1 레벨
            if (puzzleLevel == 13)
            {
                //planet.SetActive(true);
                planetSpeed = 1;
                //satellite0.SetActive(false);
                //satellite1.SetActive(false);
                //satellite2.SetActive(false);
                //satellite3.SetActive(false);
                //satellite4.SetActive(false);

                puzzleClear = false;
            }

            //1 레벨
            if (puzzleLevel == 14)
            {
                //planet.SetActive(true);
                planetSpeed = 1;
                //satellite0.SetActive(false);
                //satellite1.SetActive(false);
                //satellite2.SetActive(false);
                //satellite3.SetActive(false);
                //satellite4.SetActive(false);

                puzzleClear = false;
            }

            //1 레벨
            if (puzzleLevel == 15)
            {
                //planet.SetActive(true);
                planetSpeed = 1;
                //satellite0.SetActive(false);
                //satellite1.SetActive(false);
                //satellite2.SetActive(false);
                //satellite3.SetActive(false);
                //satellite4.SetActive(false);

                puzzleClear = false;
            }

            //1 레벨
            if (puzzleLevel == 16)
            {
                //planet.SetActive(true);
                planetSpeed = 1;
                //satellite0.SetActive(false);
                //satellite1.SetActive(false);
                //satellite2.SetActive(false);
                //satellite3.SetActive(false);
                //satellite4.SetActive(false);

                puzzleClear = false;
            }

            //1 레벨
            if (puzzleLevel == 17)
            {
                //planet.SetActive(true);
                planetSpeed = 1;
                //satellite0.SetActive(false);
                //satellite1.SetActive(false);
                //satellite2.SetActive(false);
                //satellite3.SetActive(false);
                //satellite4.SetActive(false);

                puzzleClear = false;
            }

            //1 레벨
            if (puzzleLevel == 18)
            {
                //planet.SetActive(true);
                planetSpeed = 1;
                //satellite0.SetActive(false);
                //satellite1.SetActive(false);
                //satellite2.SetActive(false);
                //satellite3.SetActive(false);
                //satellite4.SetActive(false);

                puzzleClear = false;
            }

            //1 레벨
            if (puzzleLevel == 19)
            {
                //planet.SetActive(true);
                planetSpeed = 1;
                //satellite0.SetActive(false);
                //satellite1.SetActive(false);
                //satellite2.SetActive(false);
                //satellite3.SetActive(false);
                //satellite4.SetActive(false);

                puzzleClear = false;
            }

            //1 레벨
            if (puzzleLevel == 20)
            {
                //planet.SetActive(true);
                planetSpeed = 1;
                //satellite0.SetActive(false);
                //satellite1.SetActive(false);
                //satellite2.SetActive(false);
                //satellite3.SetActive(false);
                //satellite4.SetActive(false);

                puzzleClear = false;
            }

            //1 레벨
            if (puzzleLevel == 21)
            {
                //planet.SetActive(true);
                planetSpeed = 1;
                //satellite0.SetActive(false);
                //satellite1.SetActive(false);
                //satellite2.SetActive(false);
                //satellite3.SetActive(false);
                //satellite4.SetActive(false);

                puzzleClear = false;
            }

            //1 레벨
            if (puzzleLevel == 22)
            {
                //planet.SetActive(true);
                planetSpeed = 1;
                //satellite0.SetActive(false);
                //satellite1.SetActive(false);
                //satellite2.SetActive(false);
                //satellite3.SetActive(false);
                //satellite4.SetActive(false);

                puzzleClear = false;
            }

            //1 레벨
            if (puzzleLevel == 23)
            {
                //planet.SetActive(true);
                planetSpeed = 1;
                //satellite0.SetActive(false);
                //satellite1.SetActive(false);
                //satellite2.SetActive(false);
                //satellite3.SetActive(false);
                //satellite4.SetActive(false);

                puzzleClear = false;
            }

            //1 레벨
            if (puzzleLevel == 24)
            {
                //planet.SetActive(true);
                planetSpeed = 1;
                //satellite0.SetActive(false);
                //satellite1.SetActive(false);
                //satellite2.SetActive(false);
                //satellite3.SetActive(false);
                //satellite4.SetActive(false);

                puzzleClear = false;
            }

            //1 레벨
            if (puzzleLevel == 25)
            {
                //planet.SetActive(true);
                planetSpeed = 1;
                //satellite0.SetActive(false);
                //satellite1.SetActive(false);
                //satellite2.SetActive(false);
                //satellite3.SetActive(false);
                //satellite4.SetActive(false);

                puzzleClear = false;
            }

            //1 레벨
            if (puzzleLevel == 26)
            {
                //planet.SetActive(true);
                planetSpeed = 1;
                //satellite0.SetActive(false);
                //satellite1.SetActive(false);
                //satellite2.SetActive(false);
                //satellite3.SetActive(false);
                //satellite4.SetActive(false);

                puzzleClear = false;
            }

            //1 레벨
            if (puzzleLevel == 27)
            {
                //planet.SetActive(true);
                planetSpeed = 1;
                //satellite0.SetActive(false);
                //satellite1.SetActive(false);
                //satellite2.SetActive(false);
                //satellite3.SetActive(false);
                //satellite4.SetActive(false);

                puzzleClear = false;
            }

            //1 레벨
            if (puzzleLevel == 28)
            {
                //planet.SetActive(true);
                planetSpeed = 1;
                //satellite0.SetActive(false);
                //satellite1.SetActive(false);
                //satellite2.SetActive(false);
                //satellite3.SetActive(false);
                //satellite4.SetActive(false);

                puzzleClear = false;
            }

            //1 레벨
            if (puzzleLevel == 29)
            {
                //planet.SetActive(true);
                planetSpeed = 1;
                //satellite0.SetActive(false);
                //satellite1.SetActive(false);
                //satellite2.SetActive(false);
                //satellite3.SetActive(false);
                //satellite4.SetActive(false);

                puzzleClear = false;
            }

            //1 레벨
            if (puzzleLevel == 30)
            {
                //planet.SetActive(true);
                planetSpeed = 1;
                //satellite0.SetActive(false);
                //satellite1.SetActive(false);
                //satellite2.SetActive(false);
                //satellite3.SetActive(false);
                //satellite4.SetActive(false);

                puzzleClear = false;
            }

            //1 레벨
            if (puzzleLevel == 31)
            {
                //planet.SetActive(true);
                planetSpeed = 1;
                //satellite0.SetActive(false);
                //satellite1.SetActive(false);
                //satellite2.SetActive(false);
                //satellite3.SetActive(false);
                //satellite4.SetActive(false);

                puzzleClear = false;
            }

            if (puzzleLevel == 32)
            {
                //planet.SetActive(true);
                planetSpeed = 1;
                //satellite0.SetActive(false);
                //satellite1.SetActive(false);
                //satellite2.SetActive(false);
                //satellite3.SetActive(false);
                //satellite4.SetActive(false);

                puzzleClear = false;
            }

            if (puzzleLevel == 33)
            {
                //planet.SetActive(true);
                planetSpeed = 1;
                //satellite0.SetActive(false);
                //satellite1.SetActive(false);
                //satellite2.SetActive(false);
                //satellite3.SetActive(false);
                //satellite4.SetActive(false);

                puzzleClear = false;
            }

            if (puzzleLevel == 34)
            {
                //planet.SetActive(true);
                planetSpeed = 1;
                //satellite0.SetActive(false);
                //satellite1.SetActive(false);
                //satellite2.SetActive(false);
                //satellite3.SetActive(false);
                //satellite4.SetActive(false);

                puzzleClear = false;
            }

            if (puzzleLevel == 35)
            {
                //planet.SetActive(true);
                planetSpeed = 1;
                //satellite0.SetActive(false);
                //satellite1.SetActive(false);
                //satellite2.SetActive(false);
                //satellite3.SetActive(false);
                //satellite4.SetActive(false);

                puzzleClear = false;
            }

            if (puzzleLevel == 36)
            {
                //planet.SetActive(true);
                planetSpeed = 1;
                //satellite0.SetActive(false);
                //satellite1.SetActive(false);
                //satellite2.SetActive(false);
                //satellite3.SetActive(false);
                //satellite4.SetActive(false);

                puzzleClear = false;
            }
            #endregion
        }
        yield return new WaitForSeconds(1); 
    }
}
