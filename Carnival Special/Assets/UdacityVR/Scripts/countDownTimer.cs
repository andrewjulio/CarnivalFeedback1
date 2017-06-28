using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class countDownTimer : MonoBehaviour {
	float timeRemaining = 5;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timeRemaining -= Time.deltaTime;
	}

	void OnGUI(){
		if(timeRemaining > 0){
			GUI.Label(new Rect(100, 100, 200, 100), "Countdown : "+(int)timeRemaining);
		}
		else{
			GUI.Label(new Rect(100,100,100,100), "Time's up!");
			}
	}
}
