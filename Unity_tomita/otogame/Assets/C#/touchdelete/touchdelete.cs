using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchdelete : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            GameObject[] objects = GameObject.FindGameObjectsWithTag("Destroy");
            foreach (GameObject ball in objects)
            {
                Destroy(ball);
            }
        }
    }
}