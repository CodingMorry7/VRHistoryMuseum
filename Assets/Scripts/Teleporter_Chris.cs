using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter_Chris : MonoBehaviour {

	public GameObject Teleport_Mark;
	public Transform Player;
	public string OculusButton;
	public float RayLength = 50f;
	// Use this for initialization
  void ToTeleport () {
		if(Teleport_Mark.activeSelf) {
			Vector3 markerPos = Teleport_Mark.transform.position;
			Player.position = new Vector3(markerPos.x, Player.position.y, markerPos.z);
		}
	}

	// Update is called once per frame
	void Update () {
		Ray ray = new Ray(transform.position, transform.forward);
		RaycastHit hit;
		if(Physics.Raycast(ray, out hit, RayLength)) {
			if(hit.collider.tag == "PlayArea") {
				if(!Teleport_Mark.activeSelf)  {
					Teleport_Mark.SetActive(true);
				}
				Teleport_Mark.transform.position = hit.point;
			}
			else {
				Teleport_Mark.SetActive(false);
			}
		}
		else {
			Teleport_Mark.SetActive(false);
		}

		if(OVRInput.GetDown(OVRInput.Button.One)) {
			ToTeleport();
		}
	}
}
