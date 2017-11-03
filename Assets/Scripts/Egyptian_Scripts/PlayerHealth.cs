using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

	public static int health = 100;
	public GameObject player;
	public Slider healthBar;
	private GameObject[] enemies; 

	// Use this for initialization
	void Start () {
		enemies = GameObject.FindGameObjectsWithTag("enemy");
		healthBar.value = health;
	}

	void ReduceHealth(){
		health = health - 10;
		healthBar.value = health;
	}
	// Update is called once per frame
	void Update () {
		if (IsGettingAttacked ()) {
			ReduceHealth ();
		}
	}

	bool IsGettingAttacked(){
		foreach (GameObject enemy in enemies){
			if ((player.transform.position.x - enemy.transform.position.x) < 3.0) {
				return true;
			}
		}
		return false;
	}
}
