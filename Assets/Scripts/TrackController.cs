﻿using UnityEngine;
using System.Collections;
<<<<<<< HEAD
using Leap;
=======
<<<<<<< HEAD
using Leap;
=======
<<<<<<< HEAD
//using Leap;
=======
>>>>>>> ba8e0dbcc7588b3206cc378255131b79a3096ab2
>>>>>>> FETCH_HEAD
>>>>>>> 2b2b2b786229ce573af83ebad8d837e46ca0be00

public class TrackController : MonoBehaviour {
	
	public void TurnAround (Controller ctrl) {
		Frame frame = ctrl.Frame();

		float roll = frame.Hands[0].PalmPosition.y;
		float rollRound = Mathf.Round(roll * 10);
		Debug.Log(frame.Hands.Count);
		
		transform.localEulerAngles = new Vector3(0,rollRound * Time.deltaTime,0);
		if(frame.Hands.Count > 1){
			//TODO Iets zodat de speler maar 1 hand eroverheen zet

		}
		
	}
}

