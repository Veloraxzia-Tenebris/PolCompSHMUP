﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletOffScreen : MonoBehaviour
{
	void OnBecameInvisible()
	{
		Destroy(gameObject);
	}
	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		
	}
}
