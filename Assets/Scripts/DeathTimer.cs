using UnityEngine;
using System.Collections;

public class DeathTimer : MonoBehaviour {

	private float timer = 1;
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if(timer <= 0){
			Application.LoadLevel("DeathScreen");
		}
	}
}
