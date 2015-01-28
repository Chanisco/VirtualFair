using UnityEngine;
using System.Collections;

public class Track : MonoBehaviour {

	void Update () {
		transform.Translate (Vector3.forward * Time.deltaTime * -10);
		transform.Translate (Vector3.back * Time.deltaTime * 10);
	}
}
