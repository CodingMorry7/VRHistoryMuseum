using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectHit : MonoBehaviour {

	public Slider healthBar;


	void OnTriggerEnter(Collider other){
		//if(other.CompareTag("enemy")) {
			healthBar.value = healthBar.value - 5;
			Debug.Log ("Hi");
		//}

	}
}
