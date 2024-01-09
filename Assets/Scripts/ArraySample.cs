using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraySample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] scores = new int[5]; //배열은 선언과 동시에 크기를 결정
        scores[0] = 80;
        scores[1] = 74;
        scores[2] = 81;
        scores[3] = 90;
        scores[4] = 34;

        foreach (int i in scores)
            Debug.Log(i);

        int sum = 0;

        foreach(int i in scores)
            sum += i;

        int average = sum/scores.Length;

        Debug.Log($"Average score:{average}");

    }

}
