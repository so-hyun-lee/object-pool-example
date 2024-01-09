using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MyStack<T> //���̰�
{
    List<T> values = new List<T>();
    //���ÿ� ����� ����� ��
    public int Count 
    {  
        get 
        { return values.Count; } 
    }  

    public void Push(T value)
    {
        values.Add(value);
    }

    public T Pop()
    {
        if (values.Count > 0) 
        {
            int idx = values.Count - 1;
            T result = values[idx];
            values.RemoveAt(idx);
            return result;
        }
        else 
        {
            throw new InvalidOperationException("MyStack Empty");
        }

    }
}
