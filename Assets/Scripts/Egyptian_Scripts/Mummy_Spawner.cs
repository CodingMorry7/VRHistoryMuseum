using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mummy_Spawner : MonoBehaviour {

	public GameObject mummy;
	public float spawnTime = 4f;
	public Transform[] spawnpoints;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}

	// Update is called once per frame
	void Spawn () {
		Instantiate (mummy, spawnpoints Vector3(0, 0.1, -2.3), spawnpoints [spawnIndex].rotation);
		Instantiate (mummy, spawnpoints Vector3(-48.67, 0.1, -2.3), spawnpoints [spawnIndex].rotation);
	}
}
