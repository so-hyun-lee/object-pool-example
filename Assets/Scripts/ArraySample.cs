using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraySample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] scores = new int[5]; //�迭�� ����� ���ÿ� ũ�⸦ ����
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
