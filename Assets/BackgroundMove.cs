using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
	public float speed;
	private Vector2 pos;
	// Start is called before the first frame update
	void Start()
	{
		pos = transform.position;
	}

	// Update is called once per frame
	void Update()
	{
		float newPos = Mathf.Repeat(Time.time * speed, 10.24f);
		transform.position = pos + (Vector2.down * newPos);
	}
}
