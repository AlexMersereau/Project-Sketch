using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Script : MonoBehaviour {

	public float speed = 1;
	public Vector3 direction;
	public bool useInternalForward;

	/* 
	void Start (Vector3 inDirection, float inSpeed = 1, bool inUseInternalForward = false) {
	 	direction = inDirection;
	 	speed = inSpeed;
	 	useInternalForward = inUseInternalForward;
	} */

	// Start() can't take parameters lol

	//public void Fire(Vector3 inDirection, float inSpeed = 1, bool inUseInternalForward = false) {
	public void Fire(Vector3 inDirection, float inSpeed = 1, bool inUseInternalForward = false) {
		direction = inDirection;
		speed = inSpeed;
		useInternalForward = inUseInternalForward;
	}

	void Update () {
		if (useInternalForward)
			direction = transform.forward;
		transform.Translate(direction * speed); 
	}
}
