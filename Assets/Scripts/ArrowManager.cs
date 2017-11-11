using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowManager : MonoBehaviour {
	public static ArrowManager Instance;

	public OVRInput.Controller OculusController;
	public string OculusButton;
	public GameObject arrowPrefab;
	public GameObject stringAttachPoint;

	private bool hasArrow;
	private GameObject currentArrow;

	void Awake() {
		if (Instance == null) 
			Instance = this;
	}

	void OnDestroy() {
		if (Instance == this) 
			Instance = null;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetAxis(OculusButton) == 1 && !hasArrow) {
			attachArrow();
		}
	}

	private void attachArrow() {
		if (currentArrow == null) {
			currentArrow = Instantiate (arrowPrefab);
			currentArrow.transform.parent = transform;
			currentArrow.transform.localPosition = new Vector3(0f, 0f, .132f);
		}
	}

	public void attachArrowToBow() {
		currentArrow.transform.parent = stringAttachPoint.transform;
	}
}
