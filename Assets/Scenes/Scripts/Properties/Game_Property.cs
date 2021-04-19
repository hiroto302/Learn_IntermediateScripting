using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Property : MonoBehaviour
{
    void Start()
    {
        Player_Property player1 = new Player_Property();
        Player_Property player2 = new Player_Property();

        // Properties can be used just like variables
        player1.Experience = 5000;
        int x = player1.Level;

        player2.Level = 7;
        int y = player2.Experience;

        Debug.Log(x);
        Debug.Log(y);
    }
}
