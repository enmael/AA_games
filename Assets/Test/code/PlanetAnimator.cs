/*
    생성일자 : 2025.09.06
    파일이름 : PlanetAnimator.cs
    생성자:
    내용: Planet의 애니메이션을 컨트롤 하는 코드이다 
        - 난 애니메션 컨트롤러 가지고 노는걸 잘 못한다 공부해야되는데 귀찮아.
        
        - 나무가 아무것도 없는 상태 Idle
            - 그냥 평소 상태인데 구지 재생을 해야되나
        - 나무가 발사 되어서 꼽힌 상태 Happy
            - 나무가 박힐때마다 재생 되게 하려면 현재 값과 과거의 값을 비교 하면 과거 값보다 현재 값이
            크면 재생되고 과거값 변수에 현재의 값을 넣어야겠지 
        - 나무가 있었는데 없어진 상태 Anxious
             - 과거 저장된 변수가 와 현재 변수 값 비교해서 - 이면 재생되게 수정 해야겠네 
        - 모든 나무가 없어진 상태 Die
            - 이건 bool 값으로 처리해서 평소에는 true 상태였다가 나무가 있었는데 0 
            이되면 false 해서 영구 재생되게 만들어야겠다
*/

using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.AI;

public class PlanetAnimator : MonoBehaviour
{

    [SerializeField]  WoodCounter woodCounter; 
    [SerializeField] Animator animator;
    private bool isPlaying = false;

    private int number1 = 0;
    private bool check = true;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (number1 < woodCounter.childCount)
        {
            //Happy 애니메이션 재생
            number1 = woodCounter.childCount;
            return;
        }
        else if (number1 > woodCounter.childCount)
        {
            //Anxious 애니메이션 재생
            number1 = woodCounter.childCount;

            if (number1 == 0) { check = false; } 

            return;
        }
        else if (woodCounter.childCount == 0 && check == false)
        {
            //Die 애니메이션 재생 
            return; 
        }
            
        // if (woodCounter.childCount != 0)
        // {
        //     StartCoroutine(PlayHappyThenIdle());
        // }
        // else if (woodCounter.childCount == 0)
        // {
        //     return;
        // }
        // else if()
        // if (Input.GetKeyDown(KeyCode.Space) && !isPlaying)
        //     {
        //         StartCoroutine(PlayHappyThenIdle());
        //     }
    }

    IEnumerator PlayHappyThenIdle()
    {
        isPlaying = true;

        animator.speed = 0.5f;         // 속도 느리게
        animator.Play("Happy");        // Happy 애니메이션 실행
        Debug.Log("애니메이션 코드에서 알려드림 : " + woodCounter.childCount);

        yield return new WaitForSeconds(1f); // 1초 기다림

        animator.speed = 1f;           // 속도 원래대로
        animator.Play("Idle");         // Idle로 복귀

        isPlaying = false;
    }
}

