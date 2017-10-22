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
		int spawnIndex = Random.Range (0, spawnpoints.Length);

		Instantiate (mummy, spawnpoints [spawnIndex].position, spawnpoints [spawnIndex].rotation);
	}
}
