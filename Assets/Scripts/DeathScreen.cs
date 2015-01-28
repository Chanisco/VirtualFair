using UnityEngine;
using System.Collections;

public class DeathScreen : MonoBehaviour {

	public GUISkin dsskin;
	
	void OnGUI(){
	    
	GUI.Box (new Rect (Screen.width * 0.24f, Screen.height * 0.18f, 750, 500), "End Game Screen");
	if (GUI.Button (new Rect (Screen.width * 0.4f, Screen.height * 0.75f, Screen.width * 0.2f, Screen.height * 0.1f), "Main Menu")){
		Application.LoadLevel("MainMenu");
    }
	if (GUI.Button (new Rect (Screen.width * 0.4f, Screen.height * 0.65f, Screen.width * 0.2f, Screen.height * 0.1f), "Retry")){
		Application.LoadLevel("Scene1");
	}//Scene1 is de scene waar de game in zit.
  }
}