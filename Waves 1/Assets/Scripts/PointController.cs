using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointController : MonoBehaviour {

	GameController gameController;

	public int id;

	SphereCollider sc;

	AudioSource audio;

	void Start () {
		gameController=GameObject.Find("GameController").GetComponent<GameController>();
		sc=transform.GetComponent<SphereCollider>();
		audio = GetComponent<AudioSource>();
	}
	
	void Update () {
		
	}

	void OnMouseUpAsButton() {
		if (gameController.state == 0){
			Debug.Log("Playing this sound clip");
			if (audio == null){
				Debug.Log("No audio attached!");

			}else{
				audio.Play();
			}
		}
        
    }

	void OnTriggerEnter(Collider other) {
		//Debug.Log("Collision with a trigger has happened!");
		if(other.tag=="Wave"){
			if (audio == null){
				Debug.Log("No audio attached!");

			}else{
				audio.Play();
			}
			//Debug.Log("Collision with a point has happened!");
        	bool temp =gameController.hasCollideWith(id);
        	Debug.Log(temp);
		}	

    }
}
