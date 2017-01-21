using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waveGrowthController : MonoBehaviour {

	public float WaveGrowth;

	public float ScaleAlgorithm(float scale){
		return scale*WaveGrowth;
	}
}
