using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour
{
    //ノーツのスピードを設定
    int NoteSpeed = 5;
    void Update()
    {
        //ノーツを移動させる
        transform.position -= transform.forward * Time.deltaTime * NoteSpeed;
    }
}
