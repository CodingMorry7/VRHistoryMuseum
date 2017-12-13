using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaStarThrow : MonoBehaviour {
  public static NinjaStarThrow Instance;

	//public SteamVR_TrackedObject trackedObject;
	public OVRInput.Controller OculusController;
	public string OculusButton;
	public GameObject NinjaStarPrefab;
	//public GameObject stringAttachPoint;
	//public GameObject stringStartPoint;
	//public GameObject arrowStartPoint;

	//To track player position to make arrow appear correctly.
	public bool hasNinjaStar;
	private GameObject currentStar;
	private bool isAttached = false;


	void Awake() {
		if (Instance == null)
			Instance = this;
	}

	void OnDestroy() {
		if (Instance == this)
			Instance = null;
	}

	// Update is called once per frame
	void Update () {
if(Input.GetAxis(NinjaStarThrow.Instance.OculusButton) == 1){
      attachStar();
		//	ThrowStar();

	}
}

	private void attachStar() {
		if (currentStar == null) {
			currentStar = Instantiate (NinjaStarPrefab);
			currentStar.transform.parent = transform;
			currentStar.transform.localPosition = new Vector3(0f, 0f, .342f);
			currentStar.transform.rotation = Quaternion.identity;
		}
	}
	}
