using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour
{
    //ノーツのスピードを設定
    int NoteSpeed = 6;
    bool start;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            start = true;
        }
        if (start)
        {
            //ノーツを移動させる
            transform.position -= transform.up * Time.deltaTime * NoteSpeed;
        }
    }
}
