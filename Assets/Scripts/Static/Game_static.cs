using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_static : MonoBehaviour
{
    void Start()
    {
        Enemy_static enemy1 = new Enemy_static();
        Enemy_static enemy2 = new Enemy_static();

        List<Enemy_static> enemys = new List<Enemy_static>();
        enemys.Add(enemy1);
        enemys.Add(enemy2);

        // You can access a static variable by using the class name and the dot operator.
        Debug.Log(Enemy_static.enemyCount);
        int enemyHealth = Enemy_static.AddHealth(enemys.Count);
        Debug.Log(enemyHealth);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
