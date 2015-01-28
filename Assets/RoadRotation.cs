using UnityEngine;
using System.Collections;

public class RoadRotation : MonoBehaviour {
	public float planeRotation;
	public float rotationSpeed = 5.0f;
	public float roll = 0f;
	private float m_RotationSpeed;
	// Use this for initialization
	// Update is called once per frame
	void Update (){       
		float zrot = transform.rotation.eulerAngles.z;   
		//print (zrot);

		if (Input.GetKey (KeyCode.A)) {
			if(zrot > 320 || zrot < 40){
				transform.Rotate (Vector3.forward * planeRotation * Time.deltaTime);
			}
		}

		if (Input.GetKey (KeyCode.D)) {
			if (zrot > 320 || zrot < 40){
				transform.Rotate (-Vector3.forward * planeRotation * Time.deltaTime);
			}
		}
		if (zrot > 40 && zrot < 150){
			transform.Rotate (-Vector3.forward * planeRotation * Time.deltaTime);
		}
		else if(zrot > 150 && zrot < 320){
			transform.Rotate (Vector3.forward * planeRotation * Time.deltaTime);
		}
	}
}
