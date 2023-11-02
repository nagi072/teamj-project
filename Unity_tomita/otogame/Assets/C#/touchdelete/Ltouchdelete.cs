using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ltouchdelete : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.L))
        {
            GameObject[] objects = GameObject.FindGameObjectsWithTag("Player");
            foreach (GameObject ball in objects)
            {
                Destroy(ball);
            }
        }
    }
}