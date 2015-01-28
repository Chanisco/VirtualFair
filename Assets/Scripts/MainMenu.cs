using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public GUISkin guiskin;

	void OnGUI(){
		GUI.Box (new Rect (Screen.width * 0.37f, Screen.height * 0.27f, 400, 400), "Main Menu");
		
		if(GUI.Button(new Rect(Screen.width * 0.4f,Screen.height * 0.35f,Screen.width * 0.2f,Screen.height * 0.1f), "Play")){
			Application.LoadLevel("Scene1");
		}   //Scene1 is de scene van de game.
		if (GUI.Button (new Rect (Screen.width * 0.4f, Screen.height * 0.5f, Screen.width * 0.2f, Screen.height * 0.1f), "Instructions")) {
			Application.LoadLevel("Instructions");
		}
		if (GUI.Button (new Rect (Screen.width * 0.4f, Screen.height * 0.65f, Screen.width * 0.2f, Screen.height * 0.1f), "Credits")) {
			Application.LoadLevel("Credits");
		}

	}
}