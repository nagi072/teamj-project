using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour
{
    //�m�[�c�̃X�s�[�h��ݒ�
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
            //�m�[�c���ړ�������
            transform.position -= transform.up * Time.deltaTime * NoteSpeed;
        }
    }
}
