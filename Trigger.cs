using UnityEngine;
using System.Collections;

public class Trigger : MonoBehaviour {
	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnGazeTrigger() {
		RaycastMovement raycastMovement = FindObjectOfType<RaycastMovement> ();
		raycastMovement.move = true;
	}
}
