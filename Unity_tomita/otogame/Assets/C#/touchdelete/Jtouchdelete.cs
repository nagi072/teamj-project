using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jtouchdelete : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.J))
        {
            GameObject[] objects = GameObject.FindGameObjectsWithTag("ball");
            foreach (GameObject ball in objects)
            {
                Destroy(ball);
            }
        }
    }
}