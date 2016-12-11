using UnityEngine;
using System.Collections;
//using Fungus;
public class temp : MonoBehaviour {

PlayerAssets plr;
public DeactivateSayDailogs says;
	void Awake(){
	plr = FindObjectOfType<PlayerAssets>();
	says = FindObjectOfType<DeactivateSayDailogs>();
	}
	
	void  OnEnable(){

	plr.Sell();
	Invoke("Disable",3);


	}

	public void Disable(){

		says.DisableSay();

	}

}
