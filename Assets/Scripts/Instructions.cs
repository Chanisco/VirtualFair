using UnityEngine;
using System.Collections;

public class Instructions : MonoBehaviour {

	public GUISkin isskin;

	void OnGUI(){
		GUI.Box (new Rect (Screen.width * 0.24f, Screen.height * 0.18f, 750, 500), "Instructions");

		if (GUI.Button (new Rect (Screen.width * 0.4f, Screen.height * 0.75f, Screen.width * 0.2f, Screen.height * 0.1f), "Main Menu")) {
			Application.LoadLevel ("MainMenu");
	   }
	}
}
