using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour
{
    //�m�[�c�̃X�s�[�h��ݒ�
    int NoteSpeed = 7;
    void Update()
    {
        //�m�[�c���ړ�������
        transform.position -= transform.up * Time.deltaTime * NoteSpeed;
    }
}
