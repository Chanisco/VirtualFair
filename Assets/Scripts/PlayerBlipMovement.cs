using UnityEngine;
using System.Collections;

public class PlayerBlipMovement : MonoBehaviour {

	// Update is called once per frame
	void FixedUpdate () {
		if(transform.localPosition.y < 60)
		{
			transform.Translate (Vector3.up * 0.04545454545f);
		}
	}
}
