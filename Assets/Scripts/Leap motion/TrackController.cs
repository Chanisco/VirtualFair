using UnityEngine;
using System.Collections;
using Leap;

public class TrackController : MonoBehaviour {
	Color red 	= new Color(10,0,0);
	Color green = new Color(0,10,0);
	Color blue 	= new Color(0,0,10);
	Color origin;


	public Frame frame;
	void Start(){
		origin = renderer.material.color;
	}

	public void TurnAround (Controller ctrl) {

		if(ctrl != null){
			Frame frame = ctrl.Frame();
			
			HandList h 		= frame.Hands;
			float roll 		= frame.Hands[0].PalmNormal.Roll;
			float rollRound = Mathf.Round(roll * 10);

			if(rollRound == 31){
				//TODO GUI to show you need to insert hand

			}else{
				transform.Rotate(0,0,(rollRound * 10) * Time.deltaTime);
			}

			foreach(Hand hand in h){
				if(h.Count > 1){
					//TODO GUI to show that you can't use 2 hands

				}
			}

			ColorCheck(rollRound);

		}
		
	}

	void ColorCheck(float roll){
		if(roll == 31){
			renderer.material.color = origin;
		}else if(roll > -3 && roll < 0){
			renderer.material.color = red;
		}else if(roll > 0 && roll < 3){
			renderer.material.color = green;
		} 
	}
}

