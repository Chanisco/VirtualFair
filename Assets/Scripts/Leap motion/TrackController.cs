using UnityEngine;
using System.Collections;
using Leap;

public class TrackController : MonoBehaviour {


	public SleeMovement playerDegrees;
	bool Counted = false;

	public Frame frame;

	public void TurnAround (Controller ctrl) {
		if(ctrl != null){
			Debug.Log(TrackZRotationDissorder(transform.eulerAngles.z) < -40);
		
			Frame frame = ctrl.Frame();
			
			HandList h 		= frame.Hands;
			float roll 		= frame.Hands[0].PalmNormal.Roll;
			float rollRound = Mathf.Round(roll * 10);
			if(TrackZRotationDissorder(transform.eulerAngles.z) > 40){
				if(rollRound < 0){
					rollRound = 0;
				}
			}else if(TrackZRotationDissorder(transform.eulerAngles.z) < -40){
				if(rollRound > 0){
					rollRound = 0;
				}
				
			}
			if(rollRound == 31){
				//TODO GUI to show you need to insert hand

			}else{
				transform.Rotate(0,0,(-rollRound * 10) * Time.deltaTime);
				playerDegrees.movementDegrees = TrackZRotationDissorder(transform.eulerAngles.z) * 2;
			}

			foreach(Hand hand in h){
				if(h.Count > 1){
					//TODO GUI to show that you can't use 2 hands

				}
			}

		}
		
	}

	public float TrackZRotationDissorder(float trackZ){
		if(trackZ > 180){
			trackZ -= 360;
			return trackZ;


		}else if(trackZ < 40){
			return trackZ;
		}
		return trackZ;
	}

}

