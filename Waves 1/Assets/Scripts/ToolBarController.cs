using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolBarController : MonoBehaviour {

	public GameController gc;


	int numOfTools =0;//number of tools that is avaliable

	BoxCollider bc;



	void Start () {
		bc=GetComponent<BoxCollider>();
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag=="Tool"){
			numOfTools++;
		}
	}
	
	void OnTriggerStay(Collider other){
		if (gc.state==1 && other.gameObject.tag=="Tool"){
			Destroy(other.gameObject);
			numOfTools--;
		}
	}
	void OnTriggerExit(Collider other){
		if (other.gameObject.tag == "Tool"){
			numOfTools--;
		}
	}

	void Update(){
		if (gc.state==1){
		}
	}

	void LateUpdate(){
		if (gc.state==1 && numOfTools==0){
			Destroy(gameObject);
		}
	}
}
