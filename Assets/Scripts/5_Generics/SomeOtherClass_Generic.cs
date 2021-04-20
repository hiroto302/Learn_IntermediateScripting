using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeOtherClass_Generic : MonoBehaviour
{
    void Start()
    {
        SomeClass_Generic myClass = new SomeClass_Generic();

        // In order to use this method, you must tell the method what type to replace ’T' with.
        Debug.Log(myClass.GenericMethod<int>(5).GetType());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
