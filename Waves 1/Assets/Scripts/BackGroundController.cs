using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundController : MonoBehaviour {

	public Camera cam;
	public GameObject wavePrefab;
	public GameController gc;

	bool hasMadeWave=false;

	void OnMouseUpAsButton() {
		if (gc.state==1 && !hasMadeWave){
			Vector3 p = cam.ScreenToWorldPoint(Input.mousePosition);

			GameObject newWave = Instantiate(wavePrefab,new Vector3(p.x,p.y,0),Quaternion.identity);
			hasMadeWave=true;
		}

    }
}
