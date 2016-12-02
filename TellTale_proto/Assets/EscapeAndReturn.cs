using UnityEngine;
using System.Collections;
using Fungus;
public class EscapeAndReturn : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		if(Input.GetKeyDown(KeyCode.E)){

			Fungus.Flowchart.BroadcastFungusMessage("Escape");
		} 
	
	}
}
