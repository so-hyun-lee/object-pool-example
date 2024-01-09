using System.Collections;
using System.Collections.Generic;
using System;


public class MyQueue<T>
{
    List<T> values = new List<T>(); // ���� ���� �����ϱ� ���� List<int> Ÿ���� private ��� ���� values�� ����

    public int Count { get { return values.Count; } }  // ť�� ���� ������ ��ȯ�ϴ� Count �Ӽ��� ����

    public void Enqueue(T value)  // ť�� ���� �߰��ϴ� Enqueue �޼���
    { 
        values.Add(value); 
    } 
    public T Dequeue() // ť���� ���� �����ϰ� ��ȯ
    {
        if(values.Count > 0)
        {
            int idx = 0;
            T result = values[idx];  // �ε��� 0�� �ִ� ���� �������� ���� result�� ����
            values.RemoveAt(idx); // ������ ���� ť���� ����
            return result; // ������ ���� ��ȯ
        }
        else
        {
            throw new InvalidOperationException("MyQueue Empty");
        }

    }   

}
