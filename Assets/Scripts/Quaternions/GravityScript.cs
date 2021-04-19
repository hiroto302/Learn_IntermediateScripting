using UnityEngine;
using System.Collections;

// orbit effect
public class GravityScript : MonoBehaviour
{
    public Transform target;
    public Vector3 offset = new Vector3(0, 1.5f, 0);

    void Update ()
    {

        Vector3 relativePos = (target.position + offset) - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos);

        Quaternion current = transform.localRotation;

        // lerp  : linear 一次関数
        // Slerp : Curve  二次関数
        transform.localRotation = Quaternion.Slerp(current, rotation, Time.deltaTime);

        transform.Translate(0, 0, 3 * Time.deltaTime);
    }
}