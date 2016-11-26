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
		//AchivSystem temp = new AchivSystem("Game stared~" ,true, "you began the game");
		//achivmentsTest.Add(temp);

		InitilizeAchivments();
		addEarnedAchiv( 000);
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
			SaveData();
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
		achivmentsTest.Add(000, new AchivSystem("Adventure began!~" ,false, "you began the game",10));
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
        achivmentsTest.Add(013, new AchivSystem("Game stared~", false, "you began the game", 10));
        achivmentsTest.Add(014, new AchivSystem("Game stared~", false, "you began the game", 10));
        achivmentsTest.Add(015, new AchivSystem("Game stared~", false, "you began the game", 10));
        achivmentsTest.Add(016, new AchivSystem("visted brew", false, "you began the game", 10));
        achivmentsTest.Add(017, new AchivSystem("Game stared~", false, "you began the game", 10));
        achivmentsTest.Add(018, new AchivSystem("Game stared~", false, "you began the game", 10));
        achivmentsTest.Add(019, new AchivSystem("Game stared~", false, "you began the game", 10));
        achivmentsTest.Add(020, new AchivSystem("Game stared~", false, "you began the game", 10));
        achivmentsTest.Add(021, new AchivSystem("Game stared~", false, "you began the game", 10));
        achivmentsTest.Add(022, new AchivSystem("Game stared~", false, "you began the game", 10));
        achivmentsTest.Add(023, new AchivSystem("Game stared~", false, "you began the game", 10));
        achivmentsTest.Add(024, new AchivSystem("Game stared~", false, "you began the game", 10));
        achivmentsTest.Add(025, new AchivSystem("Make it rain~", false, "you began the game", 10));
        achivmentsTest.Add(026, new AchivSystem("Game stared~", false, "you began the game", 10));
        achivmentsTest.Add(027, new AchivSystem("Game stared~", false, "you began the game", 10));
        achivmentsTest.Add(028, new AchivSystem("Game stared~", false, "you began the game", 10));
        achivmentsTest.Add(029, new AchivSystem("visted brew", false, "you began the game", 10));
        achivmentsTest.Add(030, new AchivSystem("Game stared~", false, "you began the game", 10));
        achivmentsTest.Add(031, new AchivSystem("Game stared~", false, "you began the game", 10));
        achivmentsTest.Add(032, new AchivSystem("Game stared~", false, "you began the game", 10));
        achivmentsTest.Add(033, new AchivSystem("Game stared~", false, "you began the game", 10));
        achivmentsTest.Add(034, new AchivSystem("Game stared~", false, "you began the game", 10));
        achivmentsTest.Add(035, new AchivSystem("Game stared~", false, "you began the game", 10));
        achivmentsTest.Add(036, new AchivSystem("One trick pony", false, "Only talked to one character the whole time.", 10));
        achivmentsTest.Add(037, new AchivSystem("Suspiciously Neutral", false, "finished with at least one character at friendly=0", 10));
        achivmentsTest.Add(038, new AchivSystem("Sloppy Bar Tender~", false, "Offered patron a beverage you didn’t have in stock", 10));
        achivmentsTest.Add(039, new AchivSystem("Fake Lillies~", false, "You found out about the fake lillies", 10));
        achivmentsTest.Add(040, new AchivSystem("Hooligan corner? More like politically organized youths corner~", false, "You see the evolution of your rabble rousing youth from hooligans in to disciplined political operatives.", 10));
        achivmentsTest.Add(041, new AchivSystem("Nasty Expose~", false, "Your behavior prompted someone to write a damning expose about you.", 10));
        achivmentsTest.Add(042, new AchivSystem("Quite sexist aren't we?", false, "Think about your life, think about your choices. Perhaps telling outspoken women that they are troubblemakers isn't your best move.", 10));
        achivmentsTest.Add(043, new AchivSystem("Most Wonderful Time of the Year", false, "The festival was a great sucess.", 10));
        achivmentsTest.Add(044, new AchivSystem("Where Have all the Lillies Gone~", false, "Festival fails. #wherehaveallthelilliesgone?", 10));
        achivmentsTest.Add(045, new AchivSystem("Gnome Revolution~", false, "The gnome strike is a sucess.", 10));
        achivmentsTest.Add(046, new AchivSystem("Evil Uncle Moneybags", false, "You called in the Uncle.", 10));
        achivmentsTest.Add(047, new AchivSystem("Call the Mayor~", false, "Look, this is the mayor's job. I don't want no trouble in my place.", 10));
        achivmentsTest.Add(048, new AchivSystem("Multi-beving~", false, "Bought one of each drink", 10));
        achivmentsTest.Add(049, new AchivSystem("Let Them Eat All the Cakes~", false, "Bought one of each bread", 10));
        achivmentsTest.Add(050, new AchivSystem("Meat, 'Murica ~", false, "Bought one of each meat", 10));
        achivmentsTest.Add(051, new AchivSystem("F*ck Off~", false, "Made a character so angry they left", 10));
        achivmentsTest.Add(052, new AchivSystem("Finished a Game~", false, "you finished", 10));
        achivmentsTest.Add(053, new AchivSystem("Lone Wolf~", false, "You didn't get into this business to talk to people. You got into this business to take invetory, wipe down coutners and get people drunk.", 10));
        achivmentsTest.Add(054, new AchivSystem("Pauper", false, "Lose ALLLL your money", 10));
    }


    //for dedbugging - woot works!
    public void displayAchivmentStats(){

		foreach( var  item in achivmentsTest){
			
			Debug.Log("ID"+ item.Key+" VALUE"+item.Value.unlocked);
		}
	}


	/// <summary>
	/// saving data across scene
	/// </summary>
	///this is not realistic at all idealy we will have them saved onto a json or xml file and parse from there
	/// this is just for proof of concept for now - will update later with time
	public static void SaveData(){

	//	foreach( var  item in achivmentsTest){
		int Lockedcount = 0;
		int UnlockedCOUNT = 0;
		foreach ( var item in achivmentsTest){
			if(item.Value.unlocked){

				//Debug.Log("ID"+ item.Key+" VALUE has been unlocked ");
				UnlockedCOUNT++;
				string achiv = item.Value.titile;
				//PlayerPrefs.SetString( item.Key.ToString() , achiv);
				//PlayerPrefs.SetString( item.Key.ToString() , achiv);
				PlayerPrefs.SetString( UnlockedCOUNT.ToString() , achiv);	
				Debug.Log(PlayerPrefs.GetString(UnlockedCOUNT.ToString() + " SAVED"));
			}
			if(! item.Value.unlocked){
				Lockedcount ++;
				//Debug.Log("ID"+ item.Key+" VALUE IS LOCKED ");
			}

			//	Debug.Log("ID"+ item.Key+" VALUE"+item.Value.unlocked);
		}	PlayerPrefs.SetInt("Lockedcount", Lockedcount);
			PlayerPrefs.SetInt("UnlockedCOUNT", UnlockedCOUNT);
			Debug.Log(PlayerPrefs.GetInt("Lockedcount"));
			PlayerPrefs.Save();


//		foreach ( int key in achivmentsTest.Keys){
//
//			Debug.Log(" for key "+ key.ToString() + " has the avhimcent " + achivmentsTest.Values.ToString());
//		}
	}




}
