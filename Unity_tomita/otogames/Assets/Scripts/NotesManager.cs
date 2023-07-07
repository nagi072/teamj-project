using System;
using System.Collections.Generic;
using UnityEngine;



public class NotesManager : MonoBehaviour
{
    [Serializable]
    public class Data
    {
        public string name;
        public int maxBlock;
        public int BPM;
        public int offset;
        public Note[] notes;

    }
    [Serializable]
    public class Note
    {
        public int type;
        public int num;
        public int block;
        public int LPB;
    }
    public int noteNum; //���m�[�c��
    private string songName;//�Ȗ�������ϐ�

    public List<int> LaneNum = new List<int>();//���Ԃ̃��[���Ƀm�[�c�������Ă��邩
    public List<int> NoteType = new List<int>();//���m�[�c��(�����O�m�[�c�Ƃ�)
    public List<float> NotesTime = new List<float>();//�m�[�c��������Əd�Ȃ鎞��
    public List<GameObject> NotesObj = new List<GameObject>();//GameObject

    [SerializeField] private float NotesSpeed;//�m�[�c�X�s�[�h
    [SerializeField] GameObject noteObj;//�m�[�c�̃v���n�u������


    void OnEnable()
    {
        NotesSpeed = GManager.instance.noteSpeed;
        noteNum = 0;//���m�[�c����0��
        songName = "kari.wav";//�v���C����Ȗ����擾
        Load(songName);//Load()���Ăяo��
    }

    private void Load(string SongName)
    {
        string inputString = Resources.Load<TextAsset>(SongName).ToString();
        Data inputJson = JsonUtility.FromJson<Data>(inputString); // json�t�@�C����ǂݍ���

        noteNum = inputJson.notes.Length;//���m�[�c����ݒ�
        GManager.instance.maxScore = noteNum * 5;

        for (int i = 0; i < inputJson.notes.Length; i++)
        {
            float kankaku = 60 / (inputJson.BPM * (float)inputJson.notes[i].LPB);
            float beatSec = kankaku * (float)inputJson.notes[i].LPB;
            float notesoffset = inputJson.offset * 0.01f;
            float time = (beatSec * inputJson.notes[i].num / (float)inputJson.notes[i].LPB) + notesoffset;

            NotesTime.Add(time);
            LaneNum.Add(inputJson.notes[i].block);
            NoteType.Add(inputJson.notes[i].type);

            float y = NotesTime[i] * NotesSpeed-2;
            NotesObj.Add(Instantiate(noteObj, new Vector3(inputJson.notes[i].block - 1.5f, y, -1f), Quaternion.identity));
        }
    }
}
