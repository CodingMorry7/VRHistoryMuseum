using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitByStar : MonoBehaviour {
	 public AudioSource SoundEffect;
		void OnTriggerEnter(Collider other) {
			if(other.gameObject.CompareTag("NinjaStar")){
				SoundEffect.Play();
				other.attachedRigidbody.useGravity = false;
				other.attachedRigidbody.isKinematic = true;
			}
		}
}
