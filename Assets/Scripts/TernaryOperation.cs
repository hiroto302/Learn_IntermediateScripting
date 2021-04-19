using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This is an example Ternary Operation that chooses a message
// based on the variable "health".
public class TernaryOperation : MonoBehaviour
{

    string _message;

    //The first method has a signature of "(int)".  This signature must be unique.
    public void HealthMessage(int health)
    {
        _message = health > 0 ? "Player is Alive" : "Player is Dead";
        Debug.Log(_message);
    }
    // The second method has a signature of "(int, string)". Again, this must be unique.
    public void HealthMessage(int health, string name)
    {
        _message = health > 0 ? name + " is Alive" : name + " is Dead";
        Debug.Log(_message);
    }
    public void HealthMessage(Player_Property player)
    {
        _message = player.Health > 0 ? player.Name + " is Alive" : player.Name + " is Dead";
        Debug.Log(_message);
    }
}
