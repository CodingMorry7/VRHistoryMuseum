using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayHandSound : MonoBehaviour {
	public AudioSource SoundEffect;
	 void OnTriggerEnter(Collider other) {
		 if(other.gameObject.CompareTag("Hand")){
			 SoundEffect.Play();
		 }
	 }
}
