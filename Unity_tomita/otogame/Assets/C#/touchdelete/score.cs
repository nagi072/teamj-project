using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{
    public SystemMain Sm; 
    private int Status;

    void OnCollisionEnter(Collision collision)
    {
        if (Status == 0)
        {
            Sm.Score += 100;
            Destroy(this.gameObject);
        }
    }
    void Start()
    {

        Sm = GameObject.Find("SystemMain").GetComponent<SystemMain>();
        Status = 0;
    }
}