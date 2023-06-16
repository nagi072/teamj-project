using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{
    [SerializeField] private float Speed = 3;
    [SerializeField] private int Num = 0;
    private Renderer rend;
    private float alfa = 0;
    void Start()
    {
        rend = GetComponent<Renderer>();
    }
    void Update()
    {

        if (!(rend.material.color.a <= 0))
        {
            rend.material.color = new Color(rend.material.color.r, rend.material.color.r, rend.material.color.r, alfa);
        }

        if (Num == 1)
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                colorChange();
            }
        }
        if (Num == 2)
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                colorChange();
            }
        }
        if (Num == 3)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                colorChange();
            }
        }
        if (Num == 4)
        {
            if (Input.GetKeyDown(KeyCode.J))
            {
                colorChange();
            }
        }
        if (Num == 5)
        {
            if (Input.GetKeyDown(KeyCode.K))
            {
                colorChange();
            }
        }
        if (Num == 6)
        {
            if (Input.GetKeyDown(KeyCode.L))
            {
                colorChange();
            }
        }
        alfa -= Speed * Time.deltaTime;
    }

    void colorChange()
    {
        alfa = 0.3f;
        rend.material.color = new Color(rend.material.color.r, rend.material.color.g, rend.material.color.b, alfa);
    }
}
