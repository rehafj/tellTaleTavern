using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class MyAcchivments : MonoBehaviour {

	public static List<AchivSystem> achivments = new List<AchivSystem>();
	bool Found;
	public Text AchivText;
	public GameObject achivPanel; 
	//used to add new achivments 

	public void Awake(){
		//TODO: ADD SINGLTON PATTERN TO MAKE IT APPEAR AT THE BENING BUT SO MANY DEPENDENCIES ...AGH 
		//data base option or load and save states using player prefrs ofr something 
		//or scriptable obkects 


		achivPanel = GameObject.Find("achivPanel");
		achivPanel.SetActive(false);
		AchivSystem temp = new AchivSystem("Game stared~" ,true, "you began the game");
		achivments.Add(temp);
		StartCoroutine(displayLastAciv(temp, 4));

		foreach(AchivSystem i in achivments){
			Debug.Log("added item "+ i.titile);
		}
	}
	public  void AddAchicv(string _Titile, string _dis, bool _lock= true ){

		checkIfAdded(_Titile);
		if(Found){
			Debug.Log("adding new item to achivments");
			AchivSystem temp = new AchivSystem(_Titile, _lock , _dis);
			Debug.Log(temp.titile);
			AddItem(temp);
			Debug.Log("achivments are "+ achivments.ToString());
			StartCoroutine(displayLastAciv(temp, 5));
		}
	}

	public void AddItem(AchivSystem aciv){

		achivments.Add(aciv);

	}

	public void checkIfAdded(string _titile){

		foreach( AchivSystem i in achivments){

			if(i.titile == _titile){
				Debug.Log("found is true");
				Found = false;
				break;
			}

			else 
				Found =  true;
	}}

	public IEnumerator displayLastAciv (AchivSystem a, float time){
		achivPanel.SetActive(true);
		AchivText.enabled = true;
		AchivText.text = a.titile + "Achivment unlocked!";
		Debug.Log("text feild should have "+ a.titile);
   	 	yield return new WaitForSeconds(time);
		AchivText.enabled = false;
		achivPanel.SetActive(false);
					
	}

	//TODO: move unlocked achivments throughout scenes
}
