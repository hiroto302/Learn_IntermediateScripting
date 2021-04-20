using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateScript : MonoBehaviour
{
    delegate void MyDelegate(int num);
    MyDelegate myDelegate;

    void Start()
    {
        myDelegate = PrintNum;
        myDelegate(10);

        myDelegate = DoubleNum;
        myDelegate(10);
    }

    void PrintNum(int num)
    {
        print(num);
    }
    void DoubleNum(int num)
    {
        print (num * 2);
    }
}
