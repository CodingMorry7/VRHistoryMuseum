using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitByArrow : MonoBehaviour {
public float waitTime;
 public AudioSource SoundEffect;
	void OnTriggerEnter(Collider other) {
		if(other.gameObject.CompareTag("Arrow")){
			SoundEffect.Play();
			other.attachedRigidbody.useGravity = false;
			other.attachedRigidbody.isKinematic = true;
		}
		float time = 0f;
		while(time != waitTime){
			time++;
			if(time == waitTime){
				Destroy(other.gameObject);
			}
		}

	}
}
