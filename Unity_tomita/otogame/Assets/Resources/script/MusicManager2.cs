using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager2 : MonoBehaviour
{
    AudioSource audio;
    AudioClip Music;
    string songName;
    bool played;
    void Start()
    {
        GManager.instance.Start = false;
        songName = "Let's start";
        audio = GetComponent<AudioSource>();
        Music = (AudioClip)Resources.Load("Musics/" + songName);
        played = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !played)
        {
            GManager.instance.Start = true;
            GManager.instance.StartTime = Time.time;
            played = true;
            audio.PlayOneShot(Music);
        }
    }
}