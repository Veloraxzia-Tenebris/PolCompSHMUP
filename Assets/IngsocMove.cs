using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngsocMove : MonoBehaviour
{
	private Rigidbody2D body;
	private Vector2 mov;
	public float flipPosition;
	private float speed = 2f;
	private bool direction = true;
	// Start is called before the first frame update
	void Start()
	{
		body = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void FixedUpdate()
	{
		if(direction)
		{
			mov = new Vector2(1, 0);
		}
		else
		{
			mov = new Vector2(-1, 0);
		}
		if(body.position.x >= flipPosition)
		{
			direction = false;
		}
		else if(body.position.x <= -1 * flipPosition)
		{
			direction = true;
		}
		body.AddForce(mov * speed);
	}
}
