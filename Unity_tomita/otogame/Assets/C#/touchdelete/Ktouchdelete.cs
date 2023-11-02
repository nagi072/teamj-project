using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ktouchdelete : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.K))
        {
            GameObject[] objects = GameObject.FindGameObjectsWithTag("Ball");
            foreach (GameObject ball in objects)
            {
                Destroy(ball);
            }
        }
    }
}