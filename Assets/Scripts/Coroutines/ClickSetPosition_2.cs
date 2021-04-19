using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 移動可能エリアのオブジェクトにアタッチ
public class ClickSetPosition_2 : MonoBehaviour
{
    // 移動させる対象
    public PropertiesAndCoroutines_2 coroutineScript;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                // このスクリプトをアタッチした gameObject に ray が当たった時
                if(hit.collider.gameObject == gameObject)
                // if(hit.collider.tag == "gameObject")
                {
                    Vector3 newTarget = hit.point + new Vector3(0, 0.5f, 0);
                    // 移動位置の更新
                    coroutineScript.Target = newTarget;
                }
            }
        }
    }
}
