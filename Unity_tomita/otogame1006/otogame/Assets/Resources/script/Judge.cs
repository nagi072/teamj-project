using System;
using UnityEngine;
using TMPro;//new!!
public class Judge : MonoBehaviour
{
    //変数の宣言
    [SerializeField] private GameObject[] MessageObj;//プレイヤーに判定を伝えるゲームオブジェクト
    [SerializeField] NotesManager notesManager;//スクリプト「notesManager」を入れる変数

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
            if (0 == notesManager.NotesTime.Count)
            {
                return;
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                if (notesManager.LaneNum[0] == 0)
                {
                    Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)), 0);
                }
                else
                {
                    if (notesManager.LaneNum[1] == 0)
                    {
                        Judgement(GetABS(Time.time - (notesManager.NotesTime[1] + GManager.instance.StartTime)), 1);
                    }
                }
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                if (notesManager.LaneNum[0] == 1)
                {
                    Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)), 0);
                }
                else
                {
                    if (notesManager.LaneNum[1] == 1)
                    {
                        Judgement(GetABS(Time.time - (notesManager.NotesTime[1] + GManager.instance.StartTime)), 1);
                    }
                }
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                if (notesManager.LaneNum[0] == 2)
                {
                    Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)), 0);
                }
                else
                {
                    if (notesManager.LaneNum[1] == 2)
                    {
                        Judgement(GetABS(Time.time - (notesManager.NotesTime[1] + GManager.instance.StartTime)), 1);
                    }
                }
            }
            if (Input.GetKeyDown(KeyCode.J))
            {
                if (notesManager.LaneNum[0] == 3)
                {
                    Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)), 0);
                }
                else
                {
                    if (notesManager.LaneNum[1] == 3)
                    {
                        Judgement(GetABS(Time.time - (notesManager.NotesTime[1] + GManager.instance.StartTime)), 1);
                    }

                }
            }
            if (Input.GetKeyDown(KeyCode.K))
            {
                if (notesManager.LaneNum[0] == 4)
                {
                    Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)), 0);
                }
                else
                {
                    if (notesManager.LaneNum[1] == 4)
                    {
                        Judgement(GetABS(Time.time - (notesManager.NotesTime[1] + GManager.instance.StartTime)), 1);
                    }
                }
            }
            if (Input.GetKeyDown(KeyCode.L))
            {
                if (notesManager.LaneNum[0] == 5)
                {
                    Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)), 0);
                }
                else
                {
                    if (notesManager.LaneNum[1] == 5)
                    {
                        Judgement(GetABS(Time.time - (notesManager.NotesTime[1] + GManager.instance.StartTime)), 1);
                    }
                }
            }

            if (0 == notesManager.NotesTime.Count)
            {
                return;
            }

            if (Time.time > notesManager.NotesTime[0] + 0.2f + GManager.instance.StartTime)
            {
                message(3);
                deleteData(0);
                Debug.Log("Miss");
                GManager.instance.miss++;
                GManager.instance.combo = 0;
                //ミス
            }
        }
    }
    void Judgement(float timeLag, int numOffset)
    {


        audio.PlayOneShot(hitSound);
        if (timeLag <= 0.05)
        {
            Debug.Log("Perfect");
            message(0);
            GManager.instance.ratioScore += 5;
            GManager.instance.perfect++;
            GManager.instance.combo++;
            deleteData(numOffset);
        }
        else
        {
            if (timeLag <= 0.08)
            {
                Debug.Log("Great");
                message(1);
                GManager.instance.ratioScore += 3;
                GManager.instance.great++;
                GManager.instance.combo++;
                deleteData(numOffset);
            }
            else
            {
                if (timeLag <= 0.10)
                {
                    Debug.Log("Bad");
                    message(2);
                    GManager.instance.ratioScore += 1;
                    GManager.instance.bad++;
                    GManager.instance.combo = 0;
                    deleteData(numOffset);
                }
            }
        }
    }
    float GetABS(float num)
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
    void deleteData(int numOffset)//すでにたたいたノーツを削除する関数
    {
        notesManager.NotesTime.RemoveAt(numOffset);
        notesManager.LaneNum.RemoveAt(numOffset);
        notesManager.NoteType.RemoveAt(numOffset);
        GManager.instance.score = (int)Math.Round(100000 * Math.Floor(GManager.instance.ratioScore / GManager.instance.maxScore * 100000) / 100000);
        //↑new!!
        comboText.text = GManager.instance.combo.ToString();//new!!
        scoreText.text = GManager.instance.score.ToString();//new!!
    }

    void message(int judge)//判定を表示する
    {
        Instantiate(MessageObj[judge], new Vector3(notesManager.LaneNum[0] - 2.5f, 0.76f, 1f), Quaternion.Euler(45, 0, 0));
    }
}

