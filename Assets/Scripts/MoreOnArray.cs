using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MoreOnArray : MonoBehaviour
{
    bool CheckPassed(int score)
    {
        return score >= 60;
    }

    void Print(int value)
    {
        Debug.Log(value);
    }

    // Start is called before the first frame update
    void Start()
    {
        int[] scores = new int[] { 80, 74, 81, 30, 34 };
        
        foreach (int score in scores)      
            Debug.Log($"{score}");

        Array.Sort(scores);
        Array.ForEach<int>(scores, new Action<int>(Print));

        Debug.Log("-----");

        Debug.Log($"Number of dimensions:{scores.Rank}");

        Debug.Log($"Binary Search:81 is at" +$"{Array.BinarySearch<int>(scores, 81)}");
        Debug.Log($"Linear Search:81 is at" +$"{Array.IndexOf(scores, 81)}");
        Debug.Log($"Everyone passed? : " +$"{Array.TrueForAll<int>(scores, CheckPassed)}");

        int index = Array.FindIndex<int>(scores, (score) => score < 60);

        scores[index] = 61;
        Debug.Log($"Everyone passed? : " + $"{Array.TrueForAll<int>(scores, CheckPassed)}");
        Debug.Log($"Old length of scores : " + $"{scores.GetLength(0)}");

        Array.Resize<int>(ref scores, 10);
        Debug.Log($"Newlength of scores: {scores.Length}");

        Array.ForEach(scores, new Action<int>(Print));

        Array.Clear(scores, 3, 7);
        Array.ForEach<int>(scores , new Action<int>(Print));

        int[] sliced = new int[3];
        Array.Copy(scores, 0, sliced, 0, 3);
        Array.ForEach<int>(sliced, new Action<int>(Print));





    }


}
