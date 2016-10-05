using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OverLayText : MonoBehaviour {
public PlayerAssets playerthigs;
public FameSystem currentFame;
public Text BarStatas;
public Text overLayGold;


	// Use this for initialization
	void Awake() {
		playerthigs = GameObject.FindObjectOfType<PlayerAssets>();
		currentFame = GameObject.FindObjectOfType<FameSystem>();



	}
	
	// Update is called once per frame
	void Update () {
		overLayGold.text = playerthigs.gold.ToString() + " gold";
		BarStatas.text =currentFame.getStateInString();


	
	}
}
