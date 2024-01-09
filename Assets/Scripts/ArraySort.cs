using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


class Person : IComparable<Person> , IEquatable<Person> //인터페이스선언 alt+enter해서 함수 만들어야함
{
    public string Name { get; private set;}
    public int Age { get; private set; }
    public string Id { get; private set; }

    public Person(string name, int age, string id)
    {
        this.Name = name;
        this.Age = age;
        this.Id = id;
    }
    public int CompareTo(Person other)
    {
        if(other == null) return 1;
        else return this.Age.CompareTo(other.Age);
    }

    public bool Equals(Person other)
    {
        if(other == null) return false;

        return Equals(this.Id, other.Id); //ID를 비교하여 결과값으로 나타냄
    }
}
public class ArraySort : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] scores = { 10, 30, 60, 20, 80, 50, 90, 70, 40, 35 };
        int[] newScore = MySort(scores);
        Debug.Log($"MySort : [{ string.Join(", ", newScore)}]");

        int findValue = 70;
        //int result = MyBinarySearch(newScore, findValue);
        //Debug.Log($"바이너리 서치 탐색결과 {findValue} 의 위치는 {result+1}번 째!");


        Person p1 = new Person("홍길동", 23, "001");
        Person p2 = new Person("김길동", 33, "002");
        Person p3 = new Person("이길동", 45, "003");
        Person p4 = new Person("박길동", 67, "004");
        Person p5 = new Person("최길동", 22, "005");
        Person p6 = new Person("정길동", 90, "006");
        Person p7 = new Person("고길동", 16, "007");
        Person p8 = new Person("윤길동", 35, "008");
        Person p9 = new Person("한길동", 48, "009");
        
        List<Person> list = new List<Person> {p1,p2,p3,p4,p5,p6,p7,p8,p9};
        list.Sort();
        int result = binaryAgeSearch(list.ToArray(), 35);
        Debug.Log($"{result}");

        list.Sort(new Comparison<Person>((n1,n2) => n1.Name.CompareTo(n2.Name)));
        int result2 = binaryNameSearch(list.ToArray(), "김길동",0,list.ToArray().Length -1);
        Debug.Log($"{result2}");

        Person p10 = new Person("전길동", 56, "006");
        if (p6.Equals(p10))
        {
            Debug.Log("같음");
        }
        else
        {
            Debug.Log("다름");
        }

    }

    int binaryAgeSearch(Person[] persons, int age)
    {
        int low = 0, high = persons.Length-1;
        int mid;

        while (low <= high)
        {
            mid = low + (low+high)/2;

            if (persons[mid].Age == age)
            {
                return mid;
            }
            else if (persons[mid].Age > age)
            {
                high = mid-1;
            }
            else
            {
                low = mid+1;
            }
        }
        return -1;
    }

    int binaryNameSearch(Person[] persons, string name, int myLow, int myHigh)
    {
        if (myLow > myHigh) return -1;
        if (name == null) return -1;

        int mid = myLow +(myHigh-myLow)/2;

        if (persons[mid].Name.CompareTo(name) == 0)
        {
            return mid;
        }
        else if(persons[mid].Name.CompareTo(name) > 0)
        {
            myHigh = mid-1;
            return binaryNameSearch(persons, name, myLow, myHigh);
        }
        else
        {
            myLow = mid+1;
            return binaryNameSearch(persons, name, myLow, myHigh);
        }
    }

    int MyBinarySearch(int[] scores,int findValue)
    {
        int low = 0;
        int high = scores.Length - 1;

        while (low <= high)
        {
            
            int mid = (low + high) / 2;
            if (scores[mid] == findValue) { return mid; }
            if (scores[mid] > findValue)
            {
                high = mid-1;
            }
            else
            {
                low = mid+1;
            }
        }
        return -1;
    }

    int[] MySort(int[] scores)
    {
        int[] newScore = new int[scores.Length];

        Array.Copy(scores, newScore, scores.Length);
        for(int i = 0; i < newScore.Length; i++)
        {
            for(int j = 0; j <newScore.Length-1-i; j++)
            {
                if (newScore[j]> newScore[j + 1])
                {
                    int temp = newScore[j];
                    newScore[j] = newScore[j + 1];
                    newScore[j + 1]= temp;
                }
            }
        }

       return newScore;
        
    }
}
