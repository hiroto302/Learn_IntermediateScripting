using UnityEngine;
using System.Collections;

// orbit effect : target を中心に軌道回転させる
public class GravityScript : MonoBehaviour
{
    public Transform target;
    public Vector3 offset = new Vector3(0, 1.5f, 0);

    [Range(0, 10)]
    public int distanceForward = 3;

    void Update ()
    {
        // 向く方向取得
        Vector3 relativePos = (target.position + offset) - transform.position;
        Debug.DrawRay(transform.position, relativePos, Color.blue);

        // 回転方向取得
        Quaternion rotation = Quaternion.LookRotation(relativePos);

        // 現在の回転情報を取得
        Quaternion current = transform.localRotation;

        // lerp  : linear 一次関数
        // Slerp : Curve  二次関数
        // 緩やかに、target の方向に回転させる
        transform.localRotation = Quaternion.Slerp(current, rotation, Time.deltaTime);

        // ローカル軸を基準に前方に少しずつ移動
        transform.Translate(0, 0, distanceForward * Time.deltaTime);

        // 上記の、回転させながら前方に進ませることを繰り返すことで target を中心とした軌道を描く移動を行う
    }
}