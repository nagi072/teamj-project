using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes: MonoBehaviour
{
    int NoteSpeed = 5;
    // Update is called once per frame
    void Update()
    {
        transform.position -= transform. up* Time.deltaTime * NoteSpeed;
    }
}
