using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AAA : MonoBehaviour
{
    public int a = 10;
    // Start is called before the first frame update
    void Start()
    {
        print("111");
        print("yoyo,Ð¡¶«Î÷");
        change(a);
    }

    void change(int a)
    {
        a = 100;
    }
}
