using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;//This allows the IComparable Interface

/*
This is the class you will be storing the different collections.
In order to use a collection's Sort() method, this class needs to implement the IComparable interface.
*/

public class BadGuy : IComparable<BadGuy>
{
    public string name;
    public int power;

    public BadGuy(string name, int power)
    {
        this.name = name;
        this.power = power;
    }

    // This method is required by the IComparable interface.
    public int CompareTo(BadGuy other)
    {
        if (other == null)
        {
            return 1;
        }

        // Return the difference in power.
        return power - other.power;
    }
}
