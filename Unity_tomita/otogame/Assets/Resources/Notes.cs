using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour
{
    //�m�[�c�̃X�s�[�h��ݒ�
    int NoteSpeed = 5;
    void Update()
    {
        //�m�[�c���ړ�������
        transform.position -= transform.forward * Time.deltaTime * NoteSpeed;
    }
}
