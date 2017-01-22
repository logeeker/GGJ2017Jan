using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NextButCon : MonoBehaviour {

	GameController gc;


	void Start () {
		Button btn = GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);

		gc = GameObject.Find ("GameController").GetComponent<GameController> ();
	}

	void TaskOnClick(){
		gc.loadNextScene();
	}
}
