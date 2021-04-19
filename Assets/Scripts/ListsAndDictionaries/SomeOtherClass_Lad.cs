using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeOtherClass_Lad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*
        This is how you create a Dictionary.
        Notice how this takes two generic terms.
        In this case you are using a string and a BadGuy as your two values.
        */
        Dictionary<string, BadGuy> badguys = new Dictionary<string, BadGuy>();

        BadGuy bg1 = new BadGuy("Harvey", 50);
        BadGuy bg2 = new BadGuy("Magneto", 100);

        // You can place variables into the Dictionary with the Add() method.
        badguys.Add("gangster", bg1);
        badguys.Add("mutant", bg2);

        BadGuy magneto = badguys["mutant"];
        BadGuy temp = null;

        // This is a safer, but slow, method of accessing values in a dictionary.
        // if(badguys.TryGetValue("bir", out temp))
        if(badguys.TryGetValue("mutant", out temp))
        {
            Debug.Log("Match !!");
            Debug.Log(temp.name + " " + temp.power);
        }
        else if(temp == null)
        {
            Debug.Log("Not Found Guy !!");
        }
    }
}
