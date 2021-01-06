using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
	public GameObject hit = null;
	public float health;
	private float hits = 0;
	void OnTriggerEnter2D()
	{
		hits += 1;
	}
	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void FixedUpdate()
	{
		if(hits >= health)
		{
			if(hit != null)
			{
				Instantiate(hit, transform.position, hit.transform.rotation);
			}
			Destroy(gameObject);
		}
	}
}
