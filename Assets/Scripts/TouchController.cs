using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour {

public OVRInput.Controller Controller;

	// Update is called once per frame
	// This helps with tracking the position of the controllers (Oculus Touches)
	void Update () {
			transform.localPosition = OVRInput.GetLocalControllerPosition(Controller);
			transform.localRotation = OVRInput.GetLocalControllerRotation(Controller);
	}
}
