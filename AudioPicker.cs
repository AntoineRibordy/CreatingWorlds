using UnityEngine;
using System.Collections;

public class AudioPicker : MonoBehaviour {
	public AudioClip[] soundFiles;
	public AudioSource soundSource;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!soundSource.isPlaying) {
			PlayNextSong();
		}
	}

	private void PlayNextSong (){
		int index = Random.Range (0, 7);
		soundSource.clip = soundFiles [index];
		soundSource.Play ();
	}
}
