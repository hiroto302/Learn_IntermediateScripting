using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MulticastScript : MonoBehaviour
{
    delegate void MultiDelegate();
    MultiDelegate multiDelegate;

    void Start()
    {
        multiDelegate = multiDelegate + PowerUp + TurnRed;
        multiDelegate();

        if(multiDelegate != null)
        {
            multiDelegate -= PowerUp;
            multiDelegate += TurnBlue;
            multiDelegate();             // 格納した順に実行されるので青色に上書きされる
        }

    }

    void PowerUp()
    {
        print ("Orb is powering up!");
    }

    void TurnRed()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.red;
    }
    void TurnBlue()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.blue;
    }

}
