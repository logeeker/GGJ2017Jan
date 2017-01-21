using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveController : MonoBehaviour {

	SphereCollider sc;

	public waveGrowthController wgc;

	float scale;




	// Use this for initialization
	void Start () {
		sc=transform.GetComponent<SphereCollider>();
		sc.radius=0.5f;
		scale=sc.radius/5;
	}
	
	// Update is called once per frame
	void Update () {
		scale=wgc.ScaleAlgorithm(scale);
		float tempR= scale*5;
		if (tempR>5){
			tempR=5;
		}
		sc.radius=tempR;
		transform.localScale=new Vector3(scale,scale,1);
		if (scale>=4){
			Destroy(gameObject);	
		}	
	}


}
