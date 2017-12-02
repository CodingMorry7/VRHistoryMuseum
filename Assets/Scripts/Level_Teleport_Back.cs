using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level_Teleport_Back : MonoBehaviour {
		//public AudioSource TeleportLevelSound;
		public string LevelName;
	// Update is called once per frame
	void Update () {
		if(OVRInput.GetDown(OVRInput.Button.Start)){
			//TeleportLevelSound.Play();
			Application.LoadLevel(LevelName);
		}
	}
}
