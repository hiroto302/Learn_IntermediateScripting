using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 移動させるオブジェクトにアタッチ, 移動先(target)は PropertiesAndCoroutines を用いてで指定
public class PropertiesAndCoroutines_2 : MonoBehaviour
{
    public float smoothing = 7f;
    private Vector3 target;

    int moveCount;
    public Vector3 Target
    {
        get { return target; }
        set
        {
            target = value;
            // 移動先を切り替えるためにStop
            StopCoroutine("Movement");
            // 移動先更新
            StartCoroutine("Movement", target);
        }
    }


    IEnumerator Movement (Vector3 target)
    {
        Debug.Log("movement routine..");
        moveCount++;
        Debug.Log(moveCount);
        // 移動先までの距離が0.05f以上離れている場合、更新
        while(Vector3.Distance(transform.position, target) > 0.05f)
        {
            // Debug.Log("Moveing...");
            transform.position = Vector3.Lerp(transform.position, target, smoothing * Time.deltaTime);
            yield return null;
        }
    }
}
