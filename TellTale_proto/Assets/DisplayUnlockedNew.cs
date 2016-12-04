using UnityEngine;
using System.Collections;

public class DisplayUnlockedNew : MonoBehaviour {

	// Use this for initialization
	DisplayAchiv achivm;
	void Start () {
		achivm= 	FindObjectOfType<DisplayAchiv>();
	
	}
	
	// Update is called once per frame
	void OnEnable () {

		achivm.DisplayAchivments();
	}


	void Update(){
		if(Input.GetKeyDown(KeyCode.B)){
			
			achivm.DisplayAchivments();
		}
	}
}
