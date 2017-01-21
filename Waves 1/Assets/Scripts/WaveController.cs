using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveController : MonoBehaviour {

	SphereCollider sc;


	public float waveSpeed;

	// Use this for initialization
	void Start () {
		sc=transform.GetComponent<SphereCollider>();
		sc.radius=0.1f;
	}
	
	// Update is called once per frame
	void Update () {
		sc.radius=sc.radius*waveSpeed;
		float temp = sc.radius/5;
		transform.localScale=new Vector3(temp,temp,1);
		if (sc.radius>=15){
			Destroy(gameObject);	
		}	
	}


}
