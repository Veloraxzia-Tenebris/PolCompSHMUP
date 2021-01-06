using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour
{
	public GameObject bullet;
	public float bulletOffset;
	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void FixedUpdate()
	{
		if(Input.GetKey("z"))
		{
			Instantiate(bullet, transform.position + (transform.up * bulletOffset), bullet.transform.rotation);
		}
	}
}
