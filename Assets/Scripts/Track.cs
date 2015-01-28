using UnityEngine;
using System.Collections;

public class Track : MonoBehaviour {

	void Update () {
		transform.Translate (Vector3.back * Time.deltaTime * 10);
	}
}
