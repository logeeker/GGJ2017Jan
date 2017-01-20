using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointController : MonoBehaviour {

	public GameController gameController;

	public int order;


	void Start () {
		
	}
	
	void Update () {
		
	}

	void OnMouseUpAsButton() {
		if (gameController.state == 0){
			Debug.Log("Playing this sound clip");
		}
        
    }
}
