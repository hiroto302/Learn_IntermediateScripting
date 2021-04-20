using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_static : MonoBehaviour
{
    // Static variables are shared across all instances of a class.
    public static int enemyCount;
    public int noStaticVariable;

    public Enemy_static()
    {
        enemyCount++;
    }

    /*
    A static method can be invoked without an object of a class.
    Note that static methods cannot access non-static member variables.
    */
    public static int AddHealth(int num1)
    {
        // return num1 + num2 + noStaticVariable;
        return num1 + enemyCount;
    }

}
