using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RipeApple : Fruit_polymorphism
{
    public new void SayHello()
    {
        Debug.Log("Hello, I am a RipeApple");
    }

    public override void Taste()
    {
        Debug.Log("Very Taste");
    }
}
