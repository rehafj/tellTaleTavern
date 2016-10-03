using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OverLayText : MonoBehaviour {
public PlayerAssets playerthigs;
public Text overLayGold;

	// Use this for initialization
	void Awake() {
		playerthigs = GameObject.FindObjectOfType<PlayerAssets>();

	}
	
	// Update is called once per frame
	void Update () {
	overLayGold.text = playerthigs.gold.ToString() + " gold";
	
	}
}
