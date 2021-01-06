using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
	public float speed, slow;
	private float speed2;
	private Vector2 pos;
	// Start is called before the first frame update
	void Start()
	{
		pos = transform.position;
	}

	// Update is called once per frame
	void FixedUpdate()
	{
		pos = transform.position;
		float hori = Input.GetAxisRaw("Horizontal");
		float vert = Input.GetAxisRaw("Vertical");
		Vector2 move = new Vector2(hori, vert);
		if(Input.GetKey("left shift"))
		{
			speed2 = speed / slow;
		}
		else
		{
			speed2 = speed;
		}
		transform.position = pos + (move * speed2 * 0.01f);
	}
}
