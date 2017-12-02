using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mummy_Spawner : Mummy_controller {

	public float spawnTime;

	// Use this for initialization
	void Start () {
		mummy = GetComponent<NavMeshAgent>();
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}

	void Spawn () {
		mummy.SetDestination(target.position);
		Instantiate (mummy, new Vector3(0, 0.1F, -2.3F), Quaternion.identity);
		Instantiate (mummy, new Vector3(-48.67F, 0.1F, -2.3F), Quaternion.identity);
	}
}
