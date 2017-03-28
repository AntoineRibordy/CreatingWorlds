using UnityEngine;
using System.Collections;

public class ObjectTrigger : MonoBehaviour {
	public GameObject display;
	public GameObject particle;
	public Animator stateMachine; //animator state machine
	public string animationName;

	private AudioSource soundSource;

	// Use this for initialization
	void Start () {
		soundSource = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnGazeTrigger() {
		display.SetActive (true);
		stateMachine.SetTrigger(animationName);
		soundSource.Play ();
		if (particle) {
			particle.SetActive (true);
		}
		// Should activate a trigger in an animation to make display come out of an object and grow. 
		// When player leaves, make gameobject inactive and reset animation state to idle
	}
}
