using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;			
using UnityEngine.Timeline;		

public class ScoreScript : MonoBehaviour {

	public static float scoreValue = 0f;
	Text score;

	void Start () {		
		score = GetComponent<Text> ();
	}

	void Update () {
		scoreValue = 17f * Mathf.Ceil (Time.time);
		score.text = "Distance: " + scoreValue.ToString() + "M";
	}
}

