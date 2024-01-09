using System.Collections;
using System.Collections.Generic;
using System;


public class MyQueue<T>
{
    List<T> values = new List<T>(); // 정수 값을 저장하기 위한 List<int> 타입의 private 멤버 변수 values를 선언

    public int Count { get { return values.Count; } }  // 큐의 원소 개수를 반환하는 Count 속성을 선언

    public void Enqueue(T value)  // 큐에 값을 추가하는 Enqueue 메서드
    { 
        values.Add(value); 
    } 
    public T Dequeue() // 큐에서 값을 제거하고 반환
    {
        if(values.Count > 0)
        {
            int idx = 0;
            T result = values[idx];  // 인덱스 0에 있는 값을 가져오고 변수 result에 저장
            values.RemoveAt(idx); // 가져온 값을 큐에서 제거
            return result; // 가져온 값을 반환
        }
        else
        {
            throw new InvalidOperationException("MyQueue Empty");
        }

    }   

}
