using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicClip : MonoBehaviour {

	AudioSource audio;

	public GameObject playBut;

	public GameController gc;

	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource>();
	}
	
	public void playMusic(){
		if (audio == null){
				Debug.Log("No audio attached!");

			}else{
				audio.Play();
			}
	}

	void Update(){
		if (gc.state==1){
			Destroy (playBut.gameObject);
		}
	}
}
