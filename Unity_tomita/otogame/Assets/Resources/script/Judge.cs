using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Judge : MonoBehaviour
{
    //�ϐ��̐錾
    [SerializeField] private GameObject[] MessageObj;//�v���C���[�ɔ����`����Q�[���I�u�W�F�N�g
    [SerializeField] NotesManager notesManager;//�X�N���v�g�unotesManager�v������ϐ�
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))//�Z�L�[�������ꂽ�Ƃ�
        {
            if (notesManager.LaneNum[0] == 1)//�����ꂽ�{�^���̓��[���̔ԍ��Ƃ����Ă��邩�H
            {
                Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)));
                /*
                �{���m�[�c���������ꏊ�Ǝ��ۂɂ��������ꏊ���ǂꂭ�炢����Ă��邩�����߁A
                ���̐�Βl��Judgement�֐��ɑ���
                */
            }
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (notesManager.LaneNum[0] == 2)
            {
                Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)));
            }
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (notesManager.LaneNum[0] == 3)
            {
                Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)));
            }
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            if (notesManager.LaneNum[0] == 4)
            {
                Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)));
            }
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            if (notesManager.LaneNum[0] == 5)
            {
                Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)));
            }
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            if (notesManager.LaneNum[0] == 6)
            {
                Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)));
            }
        }

        if (0 == notesManager.NotesTime.Count)
        {
            return;
        }

        if (Time.time > notesManager.NotesTime[0] + 0.21f + GManager.instance.StartTime)//�{���m�[�c���������ׂ����Ԃ���0.2�b�����Ă����͂��Ȃ������ꍇ
        {
            message(3);
            deleteData();
            Debug.Log("Miss");
            GManager.instance.miss++;
            GManager.instance.combo = 0;
            //�~�X
        }
    }
    void Judgement(float timeLag)
    {
        if (timeLag <= 0.10)//�{���m�[�c���������ׂ����ԂƎ��ۂɃm�[�c�������������Ԃ̌덷��0.1�b�ȉ���������
        {
            Debug.Log("Perfect");
            message(0);
            GManager.instance.perfect++;
            GManager.instance.combo++;
            deleteData();
        }
        else
        {
            if (timeLag <= 0.15)//�{���m�[�c���������ׂ����ԂƎ��ۂɃm�[�c�������������Ԃ̌덷��0.15�b�ȉ���������
            {
                Debug.Log("Great");
                message(1);
                GManager.instance.great++;
                GManager.instance.combo++;
                deleteData();
            }
            else
            {
                if (timeLag <= 0.20)//�{���m�[�c���������ׂ����ԂƎ��ۂɃm�[�c�������������Ԃ̌덷��0.2�b�ȉ���������
                {
                    Debug.Log("Bad");
                    message(2);
                    GManager.instance.bad++;
                    GManager.instance.combo++;
                    deleteData();
                }
            }
        }
    }
    float GetABS(float num)//�����̐�Βl��Ԃ��֐�
    {
        if (num >= 0)
        {
            return num;
        }
        else
        {
            return -num;
        }
    }
    void deleteData()//���łɂ��������m�[�c���폜����֐�
    {
        notesManager.NotesTime.RemoveAt(0);
        notesManager.LaneNum.RemoveAt(0);
        notesManager.NoteType.RemoveAt(0);
    }

    void message(int judge)//�����\������
    {
        Instantiate(MessageObj[judge], new Vector3(notesManager.LaneNum[0] - 2.5f, 0.76f, 0.15f), Quaternion.Euler(45, 0, 0));
    }
}
