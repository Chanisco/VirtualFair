using UnityEngine;
using System.Collections;

public class SleeMovement : MonoBehaviour {

	public float movementDegrees = 0;

	void Start(){
		rigidbody.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY;
	}

	void Update () {
		transform.Translate (Vector3.right * movementDegrees * Time.deltaTime / 45);
	}
	void OnCollisionExit(){
		rigidbody.constraints = RigidbodyConstraints.None;
	}
}