using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class StackQueueExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MyStack<int> stack = new MyStack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        stack.Push(5);
        stack.Push(6);

        while (stack.Count > 0)
        {
            try
            {
                int result = stack.Pop();
                Debug.Log(result);
            }
            catch (Exception e)
            {
                Debug.Log(e.Message);
            }
        }

     

        MyQueue<int> queue = new MyQueue<int>();

        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);
        queue.Enqueue(40);

        while (queue.Count > 0)
        {

            int result = queue.Dequeue();
            Debug.Log(result);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
