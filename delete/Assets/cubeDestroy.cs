using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeDestroy : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKey(KeyCode.K))
		{
			
				Destroy(gameObject);
		}
	}
}