using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabbingObjects : MonoBehaviour {
	public OVRInput.Controller OculusController;
	public string OculusButton;
	private GameObject PlayableObject;
	private bool ObjectGrabbed;
	public float grabRadius;
	public LayerMask grabMask;
	private Quaternion LastRotation;
	private Quaternion currentRotation;


	void ObjectIsGrabbed(){
		ObjectGrabbed = true;

		RaycastHit[] hits;
		hits = Physics.SphereCastAll(transform.position, grabRadius, transform.forward, 0f, grabMask);

		//We hit something and goes into the if statement
		if(hits.Length > 0){
			int closeHit = 0;
			//Go through the hits array
			for (int i = 0; i < hits.Length; i++){
				if (hits[i].distance > hits[closeHit].distance) closeHit = i;
			}
			PlayableObject = hits[closeHit].transform.gameObject;
			//PlayableObject.GetComponent<Rigidbody>().isKinematic = true;
			PlayableObject.transform.position = transform.position;
			PlayableObject.transform.parent = transform;
			//Application.LoadLevel(LevelName);
		}
	}
	// Update is called once per frame

 void ObjectIsDropped(){
	 ObjectGrabbed = false;

	 //Check if the GrabbingObject is not being used.
	 if (PlayableObject != null){
		 PlayableObject.transform.parent = null;
		 PlayableObject.GetComponent<Rigidbody>().isKinematic = false;
		 //If the object is thrown by the player and used angular velocity to make it more natural.
		 PlayableObject.GetComponent<Rigidbody>().velocity = OVRInput.GetLocalControllerVelocity(OculusController);
		 PlayableObject.GetComponent<Rigidbody>().angularVelocity = GetAngularVelocity();

		 PlayableObject = null;

	 }
}
	//Thanks to the help of Ben Roberts from Youtube to help with the Angular Velocity calculatation.

	void Update () {
		//To help calculate the angularvelocity of the PlayableObject
		if (PlayableObject != null){
			LastRotation = currentRotation;
			currentRotation = PlayableObject.transform.rotation;
		}
		//The one means the trigger is all the way down
		//If less than one means the trigger is NOT down all the way.
		if(Input.GetAxis(OculusButton) == 1) ObjectIsGrabbed();
			//Debug.Log(Time.time); // <--This is to test the button is working
		if(Input.GetAxis(OculusButton) < 1) ObjectIsDropped();
  }
	Vector3 GetAngularVelocity(){
		Quaternion deltaRotation = currentRotation * Quaternion.Inverse(LastRotation);
		return new Vector3(Mathf.DeltaAngle(0, deltaRotation.eulerAngles.x), Mathf.DeltaAngle(0, deltaRotation.eulerAngles.y), Mathf.DeltaAngle(0, deltaRotation.eulerAngles.z));
	}
}
