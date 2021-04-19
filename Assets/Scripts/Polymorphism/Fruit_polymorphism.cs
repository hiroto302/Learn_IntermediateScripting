using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit_polymorphism : MonoBehaviour
{
    public Fruit_polymorphism()
    {
        Debug.Log("1st Fruit Constructor Called");
    }

    public void Chop()
    {
        Debug.Log("The fruit has been chopped.");
    }

    public void SayHello()
    {
        Debug.Log("Hello, I am a fruit.");
    }
}
