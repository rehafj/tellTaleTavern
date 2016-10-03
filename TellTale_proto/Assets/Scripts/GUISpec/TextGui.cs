using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TextGui : MonoBehaviour {


	Text text;
	public TimeSystem time;
	public int theDay;
	// Use this for initialization
	void Awake(){
		
		text = GetComponent<Text>();

		//theDay = TimeSystem.getDay();
		string t = time.returnDaytoString();
		Debug.Log(t);
		text.text = "Day "+ t + "...";
	}

	public void Update(){
		if(Input.GetKey(KeyCode.X)){
		text = GetComponent<Text>();

		//theDay = TimeSystem.getDay();
		string t = time.returnDaytoString();
		Debug.Log(t);
		//text.text = "Day "+ t + "...";
		text.text =  t + ": "+ getRandomSaying();
		}
	}

	public void OnEnable(){

		text = GetComponent<Text>();

		//theDay = TimeSystem.getDay();
		string t = time.returnDaytoString();
		Debug.Log(t);
		string a = getRandomSaying();
		text.text =  t + ": "+ a;

	}

	public string getRandomSaying(){
		int rnf = Random.Range(1,5);
		switch(rnf){

			case 1:
				return "sigh ";
			case 2:
				return " oh joy";
			case 3:
				return "... great";
			case 4:
			return "bean farming is a thing";
			default:
				return "maybe I should live in the woods";
		}

	}

	/*
	public void OnEnable(){
		int theDay = TimeSystem.getDay();

		text.text = "Day "+ theDay + "...";
	}
	/*
	void Update(){
		if(Input.GetKeyDown(KeyCode.Z)){
			Debug.Log("scene moved");
			SceneManager.LoadScene("testingScene");
	}
		else 	if(Input.GetKeyDown(KeyCode.X)){
			Debug.Log("scene moved");
			SceneManager.LoadScene("DayTime");
	}}*/

}
