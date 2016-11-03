using UnityEngine;
using System.Collections;

public class temp : MonoBehaviour {

PlayerAssets plr;
	void Awake(){
	plr = FindObjectOfType<PlayerAssets>();
	}
	
	void  OnEnable(){

	plr.Sell();

	}
}
