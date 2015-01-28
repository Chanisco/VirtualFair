using UnityEngine;
using System.Collections;

public class Track : MonoBehaviour {

	void Update () {
		transform.Translate (Vector3.forward * Time.deltaTime * 10);
	}
}
