using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour
{
    //ノーツのスピードを設定
    int NotesSpeed = 5;
    void Update()
    {
        //ノーツを移動させる
        transform.position -= transform.up * Time.deltaTime * NotesSpeed;
    }
}
