using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class SystemMain : MonoBehaviour
{
    public int Score; 
  
    public Text ScoreText;

    void Start()
    {
        Score = 0;
    }

 
    void Update()
    {
        ScoreText.text = string.Format("{0}", Score);
    }
}
