using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutinesExample : MonoBehaviour
{
    public float smoothing = 1.0f;
    public Transform target;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(MyCoroutine(target));
        }
    }

    IEnumerator MyCoroutine(Transform target)
    {
        while(Vector3.Distance(transform.position, target.position) > 0.05f)
        {
            transform.position = Vector3.Lerp(transform.position, target.position, smoothing * Time.deltaTime);
            yield return null;
        }

        print("Reached the target !!");

        yield return new WaitForSeconds(3.0f);

        print("MyCoroutine is now finished.");
    }
}
