using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayPanels : MonoBehaviour {
	public GameObject display;
	public GameObject particle;
	public AudioSource soundSource;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerExit (Collider other){
		display.SetActive (false);
		soundSource.Stop ();
		if (particle){
			particle.SetActive (false);
		}
	}
}
