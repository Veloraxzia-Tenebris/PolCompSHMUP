using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHit : MonoBehaviour
{
	public AudioClip hitSound;
	public float despawnTime;
	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.CompareTag("Enemy"))
		{
			AudioSource.PlayClipAtPoint(hitSound, transform.position);
			Destroy(gameObject, despawnTime);
		}
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
