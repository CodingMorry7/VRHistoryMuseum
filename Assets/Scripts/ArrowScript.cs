using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ArrowScript : MonoBehaviour {


	void OnTriggerStay(){
		AttachArrow();
	}

	void OnTriggerEnter() {
		AttachArrow();
	}

	private void AttachArrow() {
		//var device = Input.GetAxis(ArrowManager.Instance.OculusController);
		if (Input.GetAxis(ArrowManager.Instance.OculusButton) == 1 && !ArrowManager.Instance.hasArrow){
		ArrowManager.Instance.attachArrowToBow();
	}
 }
}
