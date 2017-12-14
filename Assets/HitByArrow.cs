using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitByArrow : MonoBehaviour {
//public Audiosource SoundEffect;
void OnTriggerEnter(Collider other) {
	if(other.gameObject.CompareTag("Target")){
		//SoundEffect.Play();
		other.gameObject.SetActive(false);
	}
}
}
