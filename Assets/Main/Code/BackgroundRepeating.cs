using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundRepeating : MonoBehaviour
{
 [SerializeField] List<GameObject> spaceBlockList;

    void Start()
    {
        spaceBlockList.Capacity = 20;

        StartCoroutine(MyCoroutine());
    }
IEnumerator MyCoroutine()
    {
        while (true) // 무한 반복
        {
            for (int i = 0; i < spaceBlockList.Count; i++)
            {
                Vector2 pos = spaceBlockList[i].transform.position;

                if (pos.x >= 20) { pos.x = -20; }
                if (pos.y >= 20) { pos.y = -20; }

                spaceBlockList[i].transform.position = pos;
            }

            yield return new WaitForSeconds(0.1f); // 0.1초 대기
        }
    }
}
