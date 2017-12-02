using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class Mummy_controller : Axe {
	//[SerializeField]
	/*private string _lookInStumik, _walk;*/
	private NavMeshAgent mummy;
	public Transform target;
	private int health = 100;

	protected override void BaseButtons ()
	{
		//Hide the buttons
	}

	void OnTriggerEnter(Collider other) {
		if(other.CompareTag("Sword")) {
			health -= 50;
		}
	}

	IEnumerator Wait()
	 {
			 print(Time.time);
			 yield return new WaitForSeconds(3);
			 print(Time.time);
	 }

	void Start () {
		_anim.SetTrigger (_runTr);
		mummy = GetComponent<NavMeshAgent>();
		mummy.SetDestination (target.position);
	}

	// Update is called once per frame
	void Update () {
		_anim.SetTrigger (_runTr);
		mummy.SetDestination (target.position);
		if (mummy.remainingDistance < 1.0) {
			_anim.SetTrigger (_atack_1);
		}

		if (health <= 0) {
			_anim.SetTrigger (_dieTr);
			Wait();
			Destroy(mummy);
		}

	}



}
