using System;
using UnityEngine;
using TMPro;//new!!
public class Judge : MonoBehaviour
{
    //�ϐ��̐錾
    [SerializeField] private GameObject[] MessageObj;//�v���C���[�ɔ����`����Q�[���I�u�W�F�N�g
    [SerializeField] NotesManager notesManagerb;//�X�N���v�g�unotesManager�v������ϐ�

    [SerializeField] TextMeshProUGUI comboText;//new!!
    [SerializeField] TextMeshProUGUI scoreText;//new!!

    AudioSource audio;
    [SerializeField] AudioClip hitSound;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (GManager.instance.Start)
        {
            if (0 == notesManagerb.NotesTime.Count)
            {
                return;
            }

            if (Input.GetKeyDown(KeyCode.S))//�Z�L�[�������ꂽ�Ƃ�
            {
                if (notesManagerb.LaneNum[0] == 0)//�����ꂽ�{�^���̓��[���̔ԍ��Ƃ����Ă��邩�H
                {
                    Judgement(GetABS(Time.time - (notesManagerb.NotesTime[0] + GManager.instance.StartTime)), 0);
                    /*
                    �{���m�[�c���������ꏊ�Ǝ��ۂɂ��������ꏊ���ǂꂭ�炢����Ă��邩�����߁A
                    ���̐�Βl��Judgement�֐��ɑ���
                    */
                }
                else
                {
                    if (notesManagerb.LaneNum[1] == 0)
                    {
                        Judgement(GetABS(Time.time - (notesManagerb.NotesTime[1] + GManager.instance.StartTime)), 1);
                    }
                }
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                if (notesManagerb.LaneNum[0] == 1)
                {
                    Judgement(GetABS(Time.time - (notesManagerb.NotesTime[0] + GManager.instance.StartTime)), 0);
                }
                else
                {
                    if (notesManagerb.LaneNum[1] == 1)
                    {
                        Judgement(GetABS(Time.time - (notesManagerb.NotesTime[1] + GManager.instance.StartTime)), 1);
                    }
                }
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                if (notesManagerb.LaneNum[0] == 2)
                {
                    Judgement(GetABS(Time.time - (notesManagerb.NotesTime[0] + GManager.instance.StartTime)), 0);
                }
                else
                {
                    if (notesManagerb.LaneNum[1] == 2)
                    {
                        Judgement(GetABS(Time.time - (notesManagerb.NotesTime[1] + GManager.instance.StartTime)), 1);
                    }
                }
            }
            if (Input.GetKeyDown(KeyCode.J))
            {
                if (notesManagerb.LaneNum[0] == 3)
                {
                    Judgement(GetABS(Time.time - (notesManagerb.NotesTime[0] + GManager.instance.StartTime)), 0);
                }
                else
                {
                    if (notesManagerb.LaneNum[1] == 3)
                    {
                        Judgement(GetABS(Time.time - (notesManagerb.NotesTime[1] + GManager.instance.StartTime)), 1);
                    }

                }
            }
            if (Input.GetKeyDown(KeyCode.K))
            {
                if (notesManagerb.LaneNum[0] == 4)
                {
                    Judgement(GetABS(Time.time - (notesManagerb.NotesTime[0] + GManager.instance.StartTime)), 0);
                }
                else
                {
                    if (notesManagerb.LaneNum[1] == 4)
                    {
                        Judgement(GetABS(Time.time - (notesManagerb.NotesTime[1] + GManager.instance.StartTime)), 1);
                    }
                }
            }
            if (Input.GetKeyDown(KeyCode.L))
            {
                if (notesManagerb.LaneNum[0] == 5)
                {
                    Judgement(GetABS(Time.time - (notesManagerb.NotesTime[0] + GManager.instance.StartTime)), 0);
                }
                else
                {
                    if (notesManagerb.LaneNum[1] == 5)
                    {
                        Judgement(GetABS(Time.time - (notesManagerb.NotesTime[1] + GManager.instance.StartTime)), 1);
                    }
                }
            }

            if (0 == notesManagerb.NotesTime.Count)
            {
                return;
            }

            if (Time.time > notesManagerb.NotesTime[0] + 0.2f + GManager.instance.StartTime)//�{���m�[�c���������ׂ����Ԃ���0.2�b�����Ă����͂��Ȃ������ꍇ
            {
                message(3);
                deleteData(0);
                Debug.Log("Miss");
                GManager.instance.miss++;
                GManager.instance.combo = 0;
                //�~�X
            }
        }
    }
    void Judgement(float timeLag, int numOffset)
    {


        audio.PlayOneShot(hitSound);
        if (timeLag <= 0.05)//�{���m�[�c���������ׂ����ԂƎ��ۂɃm�[�c�������������Ԃ̌덷��0.1�b�ȉ���������
        {
            Debug.Log("Perfect");
            message(0);
            GManager.instance.ratioScore += 5;//new!!
            GManager.instance.perfect++;
            GManager.instance.combo++;
            deleteData(numOffset);
        }
        else
        {
            if (timeLag <= 0.08)//�{���m�[�c���������ׂ����ԂƎ��ۂɃm�[�c�������������Ԃ̌덷��0.15�b�ȉ���������
            {
                Debug.Log("Great");
                message(1);
                GManager.instance.ratioScore += 3;//new!!
                GManager.instance.great++;
                GManager.instance.combo++;
                deleteData(numOffset);
            }
            else
            {
                if (timeLag <= 0.10)//�{���m�[�c���������ׂ����ԂƎ��ۂɃm�[�c�������������Ԃ̌덷��0.2�b�ȉ���������
                {
                    Debug.Log("Bad");
                    message(2);
                    GManager.instance.ratioScore += 1;//new!!
                    GManager.instance.bad++;
                    GManager.instance.combo = 0;
                    deleteData(numOffset);
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
    void deleteData(int numOffset)//���łɂ��������m�[�c���폜����֐�
    {
        notesManagerb.NotesTime.RemoveAt(numOffset);
        notesManagerb.LaneNum.RemoveAt(numOffset);
        notesManagerb.NoteType.RemoveAt(numOffset);
        GManager.instance.score = (int)Math.Round(100000 * Math.Floor(GManager.instance.ratioScore / GManager.instance.maxScore * 100000) / 100000);
        //��new!!
        comboText.text = GManager.instance.combo.ToString();//new!!
        scoreText.text = GManager.instance.score.ToString();//new!!
    }

    void message(int judge)//�����\������
    {
        Instantiate(MessageObj[judge], new Vector3(notesManagerb.LaneNum[0] - 2.5f, 0.76f, 1f), Quaternion.Euler(45, 0, 0));
    }
}

