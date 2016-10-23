using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OverLayText : MonoBehaviour {
public PlayerAssets playerthigs;
public FameSystem currentFame;
public TimeSystem times;
public Text time;
public Text BarStatas;
public Text overLayGold;


	// Use this for initialization
	void Awake() {
		playerthigs = GameObject.FindObjectOfType<PlayerAssets>();
		currentFame = GameObject.FindObjectOfType<FameSystem>();
		times = GameObject.FindObjectOfType<TimeSystem>();


	}
	
	// Update is called once per frame
	void Update () {
		overLayGold.text = playerthigs.gold.ToString() + " gold";
		BarStatas.text = "bar status: " + currentFame.getStateInString();
		time.text = times.returnDaytoString() + " \n hour: "+times.Hour.ToString() + "min : "+times.min.ToString(); 

	
	}
}
