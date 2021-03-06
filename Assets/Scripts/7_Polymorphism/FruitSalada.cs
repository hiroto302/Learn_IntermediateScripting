using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSalada : MonoBehaviour
    {
        void Start()
        {
        /*
        Notice here how the variable "myFruit" is of type
        Fruit but is being assigned a reference to an Apple. This
        works because of Polymorphism. Since an Apple is a Fruit,
        this works just fine. While the Apple reference is stored
        in a Fruit variable, it can only be used like a Fruit
        */
        Fruit_polymorphism myFruit = new Apple();

        myFruit.SayHello();
        myFruit.Chop();

        /*
        This is called downcasting. The variable "myFruit" which is
        of type Fruit, actually contains a reference to an Apple. Therefore,
        it can safely be turned back into an Apple variable. This allows
        it to be used like an Apple, where before it could only be used
        like a Fruit.
        */
        Apple myApple = (Apple)myFruit;

        myApple.SayHello();
        myApple.Chop();

        // Notice how each Humanoid variable contains
        // a reference to a different class in the
        // inheritance hierarchy, yet each of them
        // calls SayHello() method.

        // Apple myRipApple  = new RipeApple();
        Fruit_polymorphism myRipApple  = new RipeApple();
        myRipApple.SayHello();
        }
}
