using UnityEngine;
using System.Collections;
using Fungus;
public class DeactivateSayDailogs : MonoBehaviour {

	public SayDialog [] SayDailogs;

	void Start () {
		SayDailogs = FindObjectsOfType<SayDialog>();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void DisableSay(){
		SayDailogs = FindObjectsOfType<SayDialog>();

		foreach(SayDialog _say in SayDailogs){

			_say.gameObject.SetActive(false);
			//_say.enabled = false;

	}
	}

}
