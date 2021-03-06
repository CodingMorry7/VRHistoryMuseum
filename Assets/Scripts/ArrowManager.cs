﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowManager : MonoBehaviour {
	public static ArrowManager Instance;

	//public SteamVR_TrackedObject trackedObject;
	public OVRInput.Controller OculusController;
	public string OculusButton;
	public GameObject arrowPrefab;
	public GameObject stringAttachPoint;
	public GameObject stringStartPoint;
  public GameObject arrowStartPoint;

	//To track player position to make arrow appear correctly.
	public bool hasArrow;
	private GameObject currentArrow;
	private bool isAttached = false;


	void Awake() {
		if (Instance == null)
			Instance = this;
	}

	void OnDestroy() {
		if (Instance == this)
			Instance = null;
	}

	// Update is called once per frame
	void Update () {
			attachArrow();
			PullString();

	}
	private void PullString(){
		if(isAttached){
			float dist = (stringStartPoint.transform.position - OVRInput.GetLocalControllerPosition(OculusController)).magnitude;
			stringAttachPoint.transform.localPosition = stringStartPoint.transform.localPosition + new Vector3(2f*dist, 0f, 0f);

		if (Input.GetAxis(ArrowManager.Instance.OculusButton) < 1){
		Fire();
			}
		}
	}

private void Fire() {
	float dist = (stringStartPoint.transform.position - OVRInput.GetLocalControllerPosition(OculusController)).magnitude;
	currentArrow.transform.parent = null;
  currentArrow.GetComponent<ArrowScript> ().Fired();

	Rigidbody r = currentArrow.GetComponent<Rigidbody> ();
	r.velocity = currentArrow.transform.forward * 10f * dist;
	r.useGravity = true;

	stringAttachPoint.transform.position = stringStartPoint.transform.position;
	currentArrow = null;
	isAttached = false;
}

	private void attachArrow() {
		if (currentArrow == null) {
			currentArrow = Instantiate (arrowPrefab);
			currentArrow.transform.parent = transform;
			currentArrow.transform.localPosition = new Vector3(0f, 0f, .342f);
			currentArrow.transform.rotation = Quaternion.identity;
		}
	}

	public void attachArrowToBow() {
		currentArrow.transform.parent = stringAttachPoint.transform;
		currentArrow.transform.localPosition = arrowStartPoint.transform.localPosition;
		currentArrow.transform.rotation = arrowStartPoint.transform.rotation;
		isAttached = true;
	}
}
