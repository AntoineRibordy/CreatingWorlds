using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DisplayStartPanels : MonoBehaviour {
	private Text text;
	private bool triggered = false;

	// Use this for initialization
	void Start () {
		text = GetComponentInChildren<Text> ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnGazeEnter(){
		if (!triggered) {
			triggered = true;
			StartCoroutine (DisplayText ());
		}
	}

	IEnumerator DisplayText(){
		yield return new WaitForSeconds (4);
		text.text = "VR takes this exploration to a whole new level";
		yield return new WaitForSeconds (4);
		text.text = "But how do you create virtual worlds?";
		yield return new WaitForSeconds (4);
		text.text = "When VR is ubiquitous, everyone will want to create their own world";
		yield return new WaitForSeconds (4);
		text.text = "Let's explore how we can make world creation an everyday activity for everyone";
		yield return new WaitForSeconds (4);
		text.text = "Please move around, explore this world and learn about world creation";
		yield return new WaitForSeconds (4);
		text.text = "Actionable items are spread around. Find them to hear the story";
		yield return new WaitForSeconds (4);
		text.text = "Enjoy the tour!";
		yield return new WaitForSeconds (3);
		text.text = "And if you ever get lost, follow the signs";
		yield return new WaitForSeconds (3);
		gameObject.SetActive (false);
	}
}
