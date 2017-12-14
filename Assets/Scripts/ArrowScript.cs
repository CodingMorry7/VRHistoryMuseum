using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowScript : MonoBehaviour {

	private bool isAttached = false;
	private bool isFired = false;

	void OnTriggerStay(){
		AttachArrow();
	}

	void OnTriggerEnter() {
		AttachArrow();
	}

	void Update(){
		if(isFired){
			transform.LookAt(transform.position + transform.GetComponent<Rigidbody>().velocity);
		}
	}

	public void Fired(){
		isFired = true;
	}

	private void AttachArrow() {
		//var device = Input.GetAxis(ArrowManager.Instance.OculusController);
		if (!isAttached && Input.GetAxis(ArrowManager.Instance.OculusButton) == 1 && !ArrowManager.Instance.hasArrow){
		ArrowManager.Instance.attachArrowToBow();
		isAttached = true;
	}
 }
}
