using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OverLayText : MonoBehaviour {
public PlayerAssets playerthigs;
public FameSystem currentFame;
public TimeSystem times;


public Text time;//days;
public Text Hour;
public Text Min;
public Text BarStatas;
public Text overLayGold;
CurrentScenes myState;

	// Use this for initialization
	void Awake() {
		playerthigs = GameObject.FindObjectOfType<PlayerAssets>();
		currentFame = GameObject.FindObjectOfType<FameSystem>();
		times = GameObject.FindObjectOfType<TimeSystem>();
		myState = GameObject.FindObjectOfType<CurrentScenes>();


	}
	
	// Update is called once per frame
	void Update () {

		overLayGold.text = playerthigs.gold.ToString() + " gold";

		BarStatas.text = "bar status: " + currentFame.getStateInString();

		if(myState.CurrentS == CurrentScenes.SceneStaet.market ){

			time.text = times.returnDaytoString() ;
			Hour.text = "hour: 11 " ;
			Min.text =  "min :30 AM";

		}

		else {



		time.text = times.returnDaytoString() ;

		Hour.text = "Hour:"+ times.Hour.ToString() ;

		// THIS IS JUST A QUICK FIX FOR DAY ONE - 
		if( times.Hour < 12)
		Min.text =  "min : "+times.min.ToString()+"PM"; 
		else 
			Min.text =  "min : "+times.min.ToString()+"AM"; 

	}}
}
