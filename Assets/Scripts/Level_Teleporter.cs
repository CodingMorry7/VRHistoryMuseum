using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level_Teleporter : MonoBehaviour {

	public GameObject Teleport_Lvl_Mark;
	public Transform Player;
	//public string OculusButton;
	public float RayLength = 30f;
	// Use this for initialization
	public string LevelName;
	public string LevelName2;
	//public AudioSource TeleportLevelSound;

	// Update is called once per frame
	void Update () {
		Ray ray = new Ray(transform.position, transform.forward);
		RaycastHit hit;
		if(Physics.Raycast(ray, out hit, RayLength)) {
			if(hit.collider.tag == "EgyptLevel") {
				if(!Teleport_Lvl_Mark.activeSelf)  {
					Teleport_Lvl_Mark.SetActive(true);
				}
				Teleport_Lvl_Mark.transform.position = hit.point;
				if(OVRInput.GetDown(OVRInput.Button.One)){
					//TeleportLevelSound.Play();
					Application.LoadLevel(LevelName);
				}
			}
			//Check the other Level 2
			if(hit.collider.tag == "BowAndArrowLevel") {
				if(!Teleport_Lvl_Mark.activeSelf)  {
					Teleport_Lvl_Mark.SetActive(true);
				}
				Teleport_Lvl_Mark.transform.position = hit.point;
				if(OVRInput.GetDown(OVRInput.Button.One)){
					//TeleportLevelSound.Play();
					Application.LoadLevel(LevelName);
				}
			}
			else {
				Teleport_Lvl_Mark.SetActive(false);
			}
		}
		else {
			Teleport_Lvl_Mark.SetActive(false);
		}

		//if(OVRInput.GetDown(OVRInput.Button.Two) ) {
			//Application.LoadLevel(LevelName);
		//}
	}

}
