using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class MoveToNext : MonoBehaviour {


	public TimeSystem _time;
	public bool isItTimed = false;
	public float ScreenTime = 3f;
	public GameObject nextScreen;
	//[SerializeField]
	public static  bool dayChanged = false;
	//[SerializeField]
	//public static bool n  = false;
	float startTime = Time.time;

	//this is temporary - quik fix - need to do better code than this - for SHAME SELF SHAMEEE
	//public GameObject NextScreen;
	public GameObject parentScreen;
	public GameObject MarketScreen;

	void OnEnable(){
		
		setUpTime();
	}
	// Use this for initialization
	void Start () {

		setUpTime();
		_time = GameObject.FindObjectOfType<TimeSystem>();

	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKey(KeyCode.Q)){
		MoveToNextScreen();
		}

		if(isItTimed){
			while(Time.time < startTime + ScreenTime){

				return;

			}

			if(nextScreen){
				gameObject.SetActive(false);
				nextScreen.SetActive(true);
				dayChanged = false;
				//hasmoved  = false;
			}

		}//end of timed event 
	//	if(_time.Hour>=12 && !hasmoved){
		else {//if it is  not timed - check for the current hour of the day
		if(dayChanged){
			MoveToNextScreen();
			Debug.Log("moving time is gretaer than 3");
//			//temporaty fix - have to fix timing on other script 
		//htis change should be as we update time - but issue with values - check later
		}
	
	}
	}
	void setUpTime(){
		startTime = Time.time;
	}
	public static void changedBoolValue(){

		

	}

	public void MoveToNextScreen(){
		if(nextScreen){
				gameObject.SetActive(false);
				nextScreen.SetActive(true);
				dayChanged = false;
			}

	}

	public void MoveToSelectedScreen(){
		if(parentScreen!=null){
			parentScreen.SetActive(false);
			nextScreen.SetActive(true);
			}

	}

	public void MoveToMarket(){
		if(parentScreen!=null){
			parentScreen.SetActive(false);
			nextScreen.SetActive(true);
			MarketScreen.SetActive(true);
			}

	}




	//add a method to another script to make it loop back as lon gas it is less than 7 days ...
}
