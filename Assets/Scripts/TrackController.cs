using UnityEngine;
using System.Collections;
using Leap;
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

