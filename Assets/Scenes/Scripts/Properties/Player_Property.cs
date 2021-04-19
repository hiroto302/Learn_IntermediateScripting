using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// The Player Level is determined by experience.
public class Player_Property : MonoBehaviour
{
    // Member variables can be referred to as fields.
    private int _experience;
    public int Experience
    {
        get
        {
            // some other code
            return _experience;
        }
        set
        {
            // some other code
            _experience = value;
        }
    }

    // Level is a property that converts experience
    // points into the level of a player automatically
    public int Level
    {
        get
        {
            return _experience / 1000;
        }
        set
        {
            _experience = value * 1000;
        }
    }

    //auto-implemented property
    public int Health { get; set; }
    public string Name { get; set; }
}
