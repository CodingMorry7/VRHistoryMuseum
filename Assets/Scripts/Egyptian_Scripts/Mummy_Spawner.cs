using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mummy_Spawner : Mummy_controller {

	// Use this for initialization
	void Start () {
		InvokeRepeating ("Spawn", 10.0f, 10.0f);
	}

	void Spawn () {
		mummy = GetComponent<NavMeshAgent>();
		mummy.SetDestination(target.position);
		Instantiate (mummy, new Vector3(0, 0.1F, -2.3F), Quaternion.identity);
		Instantiate (mummy, new Vector3(-48.67F, 0.1F, -2.3F), Quaternion.identity);
	}
}
