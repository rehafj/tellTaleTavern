using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
///main achivment system 

/// <summary>
/// new classs for achivmenet managment 
/// </summary>
public class AchivmentsTest : MonoBehaviour {


	public static Dictionary < int ,AchivSystem> achivmentsTest = new Dictionary < int ,AchivSystem>();
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
		//achivmentsTest.Add(temp);
		achivmentsTest.Add(000, temp);
		InitilizeAchivments();
		StartCoroutine(displayLastAciv(achivmentsTest[000], 4));

		//foreach(AchivSystem i in achivmentsTest){
		//	Debug.Log("added item "+ i.titile);
		}

	public void Update(){

		if(Input.GetKeyDown(KeyCode.Space)){
			Debug.Log("adislay achivments");
			displayAchivmentStats();
		//achivmentsTest.Add(temp);


		}
		if(Input.GetKeyDown(KeyCode.A)){
			Debug.Log("achivemtn a added");
			addEarnedAchiv(005);
		//achivmentsTest.Add(temp);


		}
	}

	//can be used and called from fungus 
	/*public  void AddAchicv(string _Titile, string _dis, bool _lock= true ){

			Debug.Log("adding new item to achivments");
			AchivSystem temp = new AchivSystem(_Titile, _lock , _dis);
			Debug.Log(temp.titile);
		
			StartCoroutine(displayLastAciv(temp, 5));
		}*/
	
	//can be used and called from fungus 
	//to unlock the achiv 
	public void addEarnedAchiv(int ID){
		if(achivmentsTest[ID].unlockAchiv()){

			StartCoroutine(displayLastAciv(achivmentsTest[ID], 5));
			
	}

	}

	//}}

	public IEnumerator displayLastAciv (AchivSystem a, float time){
		achivPanel.SetActive(true);
		AchivText.enabled = true;
		AchivText.text = a.titile + "Achivment unlocked!";
		Debug.Log("text feild should have "+ a.titile);
   	 	yield return new WaitForSeconds(time);
		AchivText.enabled = false;
		achivPanel.SetActive(false);
					
	}


	//add all achivments here - achivment name 0 titile - keep it at false here - discription - points worth 
	public void InitilizeAchivments(){

		achivmentsTest.Add(001, new AchivSystem("Game stared~" ,false, "you began the game",10));
		achivmentsTest.Add(002, new AchivSystem("Game stared~" ,false, "you began the game",10));
		achivmentsTest.Add(003, new AchivSystem("Game stared~" ,false, "you began the game",10));
		achivmentsTest.Add(004, new AchivSystem("visted brew" ,false, "you began the game",10));
		achivmentsTest.Add(005, new AchivSystem("Game stared~" ,false, "you began the game",10));
		achivmentsTest.Add(006, new AchivSystem("Game stared~" ,false, "you began the game",10));
		achivmentsTest.Add(007, new AchivSystem("Game stared~" ,false, "you began the game",10));
		achivmentsTest.Add(008, new AchivSystem("Game stared~" ,false, "you began the game",10));
		achivmentsTest.Add(009, new AchivSystem("Game stared~" ,false, "you began the game",10));
		achivmentsTest.Add(010, new AchivSystem("Game stared~" ,false, "you began the game",10));
		achivmentsTest.Add(011, new AchivSystem("Game stared~" ,false, "you began the game",10));
		achivmentsTest.Add(012, new AchivSystem("Game stared~" ,false, "you began the game",10));
		achivmentsTest.Add(333, new AchivSystem("Make it rain~" ,false, "you began the game",10));


	}


	//for dedbugging - woot works!
	public void displayAchivmentStats(){

		foreach( var  item in achivmentsTest){
			
			Debug.Log("ID"+ item.Key+" VALUE"+item.Value.unlocked);
		}
	}
}
