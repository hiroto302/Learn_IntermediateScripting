using UnityEngine;
using System.Collections;

public class LookAtScript : MonoBehaviour
{
    public Transform target;

    void Update ()
    {
        /* LookRotation
            指定された forward と upwards(defaults to Vector3.up) 方向に回転
        */
        // 向く方向
        Vector3 relativePos = target.position - transform.position;
        Debug.DrawRay (transform.position, relativePos, Color.blue);
        // 向く方向をLookRotationの引数に指定し、Quaternion型でその回転方向を得る
        transform.rotation = Quaternion.LookRotation(relativePos);

    }
}
