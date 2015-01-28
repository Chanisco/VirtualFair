using UnityEngine;
using System.Collections;

public class Credits : MonoBehaviour {

	public GUISkin crskin;

	void OnGUI(){
	GUI.Box (new Rect (Screen.width * 0.37f, Screen.height * 0.18f, 400, 500), "Credits");

	GUI.Label (new Rect (Screen.width * 0.47f, Screen.height * 0.25f, Screen.width * 0.2f, Screen.height * 0.1f), "Chanisco Tromp");
	GUI.Label (new Rect (Screen.width * 0.47f, Screen.height * 0.3f, Screen.width * 0.2f, Screen.height * 0.1f), "Jim Warmerdam");
	GUI.Label (new Rect (Screen.width * 0.47f, Screen.height * 0.35f, Screen.width * 0.2f, Screen.height * 0.1f), "Cees van Wanrooy");
	GUI.Label (new Rect (Screen.width * 0.47f, Screen.height * 0.4f, Screen.width * 0.2f, Screen.height * 0.1f), "Jeffrey Laarman");
	GUI.Label (new Rect (Screen.width * 0.47f, Screen.height * 0.45f, Screen.width * 0.2f, Screen.height * 0.1f), "Nick van Dokkum");	
	GUI.Label (new Rect (Screen.width * 0.47f, Screen.height * 0.5f, Screen.width * 0.2f, Screen.height * 0.1f), "Soufyan Hassan");	
	GUI.Label (new Rect (Screen.width * 0.47f, Screen.height * 0.55f, Screen.width * 0.2f, Screen.height * 0.1f), "Tino Kort");	
	GUI.Label (new Rect (Screen.width * 0.47f, Screen.height * 0.6f, Screen.width * 0.2f, Screen.height * 0.1f), "Lorenzo Koning");	
	GUI.Label (new Rect (Screen.width * 0.47f, Screen.height * 0.65f, Screen.width * 0.2f, Screen.height * 0.1f), "Jessie Spitteler");	
	GUI.Label (new Rect (Screen.width * 0.47f, Screen.height * 0.7f, Screen.width * 0.2f, Screen.height * 0.1f), "Dylan Waij");
	GUI.Label (new Rect (Screen.width * 0.47f, Screen.height * 0.75f, Screen.width * 0.2f, Screen.height * 0.1f), "Casper Oostdam");	
	if (GUI.Button (new Rect (Screen.width * 0.4f, Screen.height * 0.8f, Screen.width * 0.2f, Screen.height * 0.1f), "Main Menu")) {
		Application.LoadLevel ("MainMenu");
	 }
   }
}