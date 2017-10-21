using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class AI_Move : MonoBehaviour {

	private NavMeshAgent mummy;
	public Transform target;

	// Use this for initialization
	void Start () {
		mummy = GetComponent<NavMeshAgent>();
	}

	// Update is called once per frame
	void Update () {
		mummy.SetDestination (target.position);
	}
}
