﻿using UnityEngine;
using System.Collections;

public class SleeMovement : MonoBehaviour {

	public float movementDegrees = 0;
	private bool falling = false;
	private int movement = 0;
	public float movementSpeed = 20;

	void Start(){
		rigidbody.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY;
	}

	void Update () {
		Vector3 temp = transform.rotation.eulerAngles;
		temp.y = 0;
		transform.rotation = Quaternion.Euler(temp);
		transform.Translate (Vector3.right * movement * Time.deltaTime * movementSpeed);
		if(falling == false){
			transform.Translate (Vector3.right * movementDegrees * Time.deltaTime / 45);
		}
		//transform.Rotate(Vector3.up, -1 * Time.deltaTime);
		if(Input.GetKey(KeyCode.A)){
			movement = -1;
		}
		else if(Input.GetKey(KeyCode.D)){
			movement = 1;
		}
		else {
			movement = 0;
		}
	}
	void OnCollisionExit(){
		rigidbody.constraints = RigidbodyConstraints.None;
		falling = true;
	}
}