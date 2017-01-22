using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	public int state=0;

	public GameObject startButton;
	public GameObject Texts;
	public int index =0;

	GameObject canvas;
	GameObject points;
	public GameObject plane;
	public GameObject winPage;
	public GameObject losePage;

	public int gameState;// 0 is runing, 1 is lose, 2 is win

	public int[] theOrder;


	/*
	state = 0;
	player is identifying the pitch of each point
	state = 1;
	player has figured out the solution (or hope so) and is now giving a try.
	*/

	// Use this for initialization
	void Start () {
		canvas = GameObject.Find ("Canvas");
		points = GameObject.Find ("Points");

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp("space")){
			loadNextScene();
		}


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
		if (index >= theOrder.Length) {
			index = theOrder.Length-1;
		}
		if (theOrder[index]==id){
			//Debug.Log("True");

		}else{
			
			Debug.Log("Should be "+ theOrder[index]+" but get "+ id);
			Debug.Log("Lose");
			rtn=false;
			lose ();
		}
		index++;

		return rtn;

	}

	public bool checkComplition(){
		bool temp = index == theOrder.Length;
		if (!temp) {
			Debug.Log ("Index is " + index + " theOrder.Length is " + theOrder.Length);
		}
		if (temp) {
			win ();
		} else {
			lose ();
		}
		return temp;
	}

	public void win(){
		if (gameState == 0) {
			gameState = 1;
			Instantiate (plane, new Vector3 (0, 0, -7f), Quaternion.Euler(-90f,0,0));
			GameObject wPage = Instantiate (winPage, Vector3.zero, Quaternion.identity);
			wPage.transform.parent = canvas.transform;
			wPage.GetComponent<RectTransform> ().localPosition = Vector3.zero;


			Destroy (points);

		}
	}

	public void lose(){
		if (gameState == 0) {
			gameState = 1;
			Instantiate (plane, new Vector3 (0, 0, -7f), Quaternion.Euler(-90f,0,0));
			GameObject lPage = Instantiate (losePage, Vector3.zero, Quaternion.identity);
			lPage.transform.parent = canvas.transform;
			lPage.GetComponent<RectTransform> ().localPosition = Vector3.zero;

			Destroy (points);

		}
	}

	public void reloadScene(){
		Scene loadedLevel = SceneManager.GetActiveScene ();
		SceneManager.LoadScene (loadedLevel.buildIndex);
	}

	public void loadNextScene(){
		Scene loadedLevel = SceneManager.GetActiveScene ();
		SceneManager.LoadScene (loadedLevel.buildIndex+1);
	}

	public void loadMainMenu(){
		
		SceneManager.LoadScene(0);
	}
}
