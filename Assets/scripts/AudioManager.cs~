using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {

	public static AudioManager instance;

	AudioClip clipMain;
	public AudioSource audioMain,audioConfig;


	// Use this for initialization
	void Awake () {
		if (instance == null) {
			instance = this;
			DontDestroyOnLoad (this.gameObject);
		} else {
			Destroy (gameObject);
		}
	}
	public void AudioMain(){
		audioMain.clip = clipMain;
		audioMain.Play ();
	}



}
