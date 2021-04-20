using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TastingMan : MonoBehaviour
{
    List<Fruit_polymorphism> _fruits = new List<Fruit_polymorphism>();

    void Start()
    {

        Fruit_polymorphism myApple = new Apple();
        _fruits.Add(myApple);
        Fruit_polymorphism myRipeApple = new RipeApple();
        _fruits.Add(myRipeApple);

        // Notice that the Apple version of the methods
        // override the fruit versions. Also notice that
        // since the Apple versions call the Fruit version with
        //t he "base" keyword, both are called.

        // Overriding is also useful in a polymorphic situation.
        // Since the methods of the Fruit class are "virtual" and
        // the methods of the RipeApple class are "override", when we
        // upcast an RipeApple into a Fruit, the RipeApple version of the
        // Methods are used

        foreach(var apple in _fruits)
        {
            apple.Taste();
        }

    }
}
