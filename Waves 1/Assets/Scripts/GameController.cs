using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	
	public int state=0;

	public GameObject startButton;
	/*
	state = 0;
	player is identifying the pitch of each point
	state = 1;
	player has figured out the solution (or hope so) and is now giving a try.
	*/

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void StartButtonClicked(){
		state=1;
		Debug.Log("Game has started");
		Destroy(startButton);
	}
}
