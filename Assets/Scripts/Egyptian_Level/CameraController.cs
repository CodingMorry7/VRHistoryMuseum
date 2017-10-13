using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public static Camera mainCam;
	// Use this for initialization
	void Start () {
		mainCam = Camera.main;
		mainCam.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		mainCam.enabled = true;
	}
}
