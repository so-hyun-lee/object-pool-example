using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingHashTable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Hashtable ht = new Hashtable();
        ht["�ϳ�"] = "one";
        ht["��"] = "two";
        ht["��"] = "three";
        ht["��"] = "four";
        ht["�ټ�"] = "five";

        Debug.Log(ht["�ϳ�"]);
        Debug.Log(ht["��"]);
        Debug.Log(ht["��"]);
        Debug.Log(ht["��"]);
        Debug.Log(ht["�ټ�"]);
    }


}
