using UnityEngine;
using System.Collections;

public class MusicBackground : MonoBehaviour {

	public AudioClip[] backgroundClips;

	// Use this for initialization
	void Start () {
		audio.clip = backgroundClips[0];
		audio.loop = false;
		audio.Play();
	}
	
	// Update is called once per frame
	void Update () {
		if (!audio.isPlaying){
			audio.clip = backgroundClips[1];
			audio.loop = true;
			audio.Play();
		}
	
	}
}
