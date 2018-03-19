using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot_Bullets : MonoBehaviour {

	public Rigidbody2D bullet;
	private float timer;		//internal; counts how long since last bullet fire
	public int frequency;		//seconds between firing

	void Start(){
		timer = 0;
	}

	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer > frequency) {
			shootBullet ();
			timer = 0;
		}
	}

	void shootBullet(){
		Rigidbody2D firedBullet;
		firedBullet = Instantiate (bullet, transform.position, transform.rotation) as Rigidbody2D;
		firedBullet.velocity = transform.TransformDirection (Vector3.forward * 2);
	}
}
