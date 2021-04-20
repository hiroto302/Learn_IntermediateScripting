﻿using UnityEngine;
using System.Collections;

// 移動スクリプト
public class MotionScript : MonoBehaviour
{
    public float speed = 3f;
    void Update ()
    {
        transform.Translate(-Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0);
    }
}