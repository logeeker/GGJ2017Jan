﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reflector : MonoBehaviour {

	public GameObject wavePrefab;
	SphereCollider sc;

	public GameController gc;
	public Camera cam;

	void OnMouseDrag(){
		if (gc.state==0){

			Vector3 p = cam.ScreenToWorldPoint(Input.mousePosition);
			transform.position=new Vector3(p.x,p.y,0);
		}
	}

	void Start () {
		sc=GetComponent<SphereCollider>();
	}


	void OnTriggerEnter(Collider other) {
		Debug.Log("Collision with a trigger has happened!");
		if(other.tag=="Wave"){
			Debug.Log("Collision with a point has happened!");
        	Destroy(other.gameObject);
			Destroy(sc);
			GameObject newWave = Instantiate(wavePrefab,transform.position,Quaternion.identity);

		}	

    }
}