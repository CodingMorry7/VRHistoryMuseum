using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mummy_Controller : BaseAnimController
{
	//[SerializeField]
	/*private string _lookInStumik, _walk;*/
	private NavMeshAgent mummy;
	public Transform target;

	protected override void BaseButtons ()
	{
		//Hide buttons
	}

	void Start () {
		_anim.SetTrigger (_runTr);
		mummy = GetComponent<NavMeshAgent>();

	}

	// Update is called once per frame
	void Update () {
		_anim.SetTrigger (_runTr);
		mummy.SetDestination (target.position);
		if (mummy.remainingDistance < 1.0) {
			_anim.SetTrigger (_atack_0_Tr);
		}
	}

	/*protected override void BaseButtons ()
	{
		base.BaseButtons ();

		if (GUI.Button (new Rect (10, 140, 100, 50), "LookInStumik")) {
			_anim.SetTrigger (_lookInStumik);
		}

		if (GUI.Button (new Rect (10, 200, 100, 50), "Walk")) {
			_anim.SetTrigger (_walk);
		}
	}*/


}
	

