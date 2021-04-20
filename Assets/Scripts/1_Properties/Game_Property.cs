using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Property : MonoBehaviour
{
    void Start()
    {
        Player_Property player1 = new Player_Property();
        Player_Property player2 = new Player_Property();

        TernaryOperation ternaryOperation = new TernaryOperation();

        // Properties can be used just like variables
        player1.Experience = 5000;
        int x = player1.Level;
        player1.Health = 10;

        player2.Level = 7;
        int y = player2.Experience;
        player2.Name = "２号";

        Debug.Log(x);
        Debug.Log(y);
        // The specific HealthMessage method called will depend on the arguments passed in.
        ternaryOperation.HealthMessage(player1.Health, nameof(player1));
        ternaryOperation.HealthMessage(player2);
    }
}

