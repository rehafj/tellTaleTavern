using UnityEngine;
using System.Collections;

public class EnableFlowOnDay : MonoBehaviour {

	public TimeSystem _time;
	// Use this for initialization
	void Awake () {
	_time = FindObjectOfType<TimeSystem>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
