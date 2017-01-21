using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public int state=0;

	public GameObject startButton;
	public GameObject Texts;
	public int index =0;

	public int[] theOrder;


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
		Destroy(Texts);
	}

	public bool hasCollideWith(int id){
		bool rtn = true;
		//Debug.Log("this is "+theOrder[index]+" next is "+theOrder[index+1]);
		if (theOrder[index]==id){
			//Debug.Log("True");

		}else{
			
			Debug.Log("Should be "+ theOrder[index]+" but get "+ id);
			Debug.Log("Lose");
			rtn=false;
		}

		index++;
		return rtn;

	}

	public bool checkComplition(){
		return index==theOrder.Length-1;
	}
}
