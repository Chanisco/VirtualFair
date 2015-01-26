using UnityEngine;
using System.Collections;
using Leap;

public class LeapMotionControllers : MonoBehaviour {
	public static Controller controller;

	TrackController TrackCheck;

	void Awake () {
		controller = new Controller(); 

		TrackCheck = (TrackController)GetComponent<TrackController>();

	}
	
	// Update is called once per frame
	void Update () {
		TrackCheck.TurnAround(controller);
	}
}
