using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class DisplayAchiv : MonoBehaviour {

	private static DisplayAchiv _instance;
	public static DisplayAchiv Instance { get { return _instance; } }

	int UnlockedCount;
	int lockedCount;
	public Text achivTxt;

	public Text DisplaYukedTtile;
	public Text diplsayInformation;

	string mystring ="";
	string discription ="";
	int totoalAchivDayOne = 10; // add totoal number of achiv for ep 1
	public  Dictionary < string ,string> achivStrings = new Dictionary < string , string>();
	public  Dictionary < int ,AchivSystem> MovingAchiv = new Dictionary < int , AchivSystem>();

	AchivmentsTest myAchivments; 

	void Awake(){

		DontDestroyOnLoad(gameObject);

		myAchivments = FindObjectOfType<AchivmentsTest>();

		if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        } else {
            _instance = this;
        }

	
	}
	public void FindObjects(){
		DisplaYukedTtile = GameObject.Find("AT1").GetComponent<Text>();
		diplsayInformation = GameObject.Find("AT2").GetComponent<Text>();
		achivTxt = GameObject.Find("AT3").GetComponent<Text>();

	}
//	void Start(){
//
//		DisplaYuNLOKCED = GameObject.Find("AT1").GetComponent<Text>();
//		diplsayInformation = GameObject.Find("AT2").GetComponent<Text>();
//
//	}
	void Update(){

		if( Input.GetKeyDown(KeyCode.Q)){
		//	/aveAchivmAcrossScenes();
			SaveAchivAcrossScenes();
			foreach( int k in MovingAchiv.Keys)
			Debug.Log("avhivment unlocked as ID has "+ k);

		}
		if( Input.GetKeyDown(KeyCode.W)){
			displayAchivmentsEarened();


		}

	}

	public void DisplayAchivments(){ //with all item values 

		//add a bool for a can click statment 
		DisplaYukedTtile.text ="";
		diplsayInformation.text = "";
		int count = totoalAchivDayOne;

		foreach (var k in MovingAchiv) {
			
		//dupilcate code just for testing for now 
			string x = k.Value.titile;

		// mystring = mystring.ToString() +  s.ToString() + "\n" ;
			mystring = mystring.ToString() + x + "-\n";

			 discription = discription.ToString() + k.Value.discription+"- gold \n";


			DisplaYukedTtile.text = mystring +" " ;
			diplsayInformation.text =discription + " " ;
			count--;
			//can add a yext field to dispaly ??? for all uncolleccted achiv -- ask team 

		} 

		printX(count);

		}

	public void printX ( int counter){
		for ( int i = 0; i< counter ; i ++){
			achivTxt.text  = "acivment  : ????????????\n";
			
		}


	}
	//caall this method to save it into this dictionary 
	public void SaveAchivmAcrossScenes(){
		achivStrings.Clear();
		achivStrings = myAchivments.GetAchivmentsAsString();
		//test
	}
	public void SaveAchivAcrossScenes(){
		MovingAchiv.Clear();//this may produce a bug
		MovingAchiv = myAchivments.GetAchivmentsAsAchiv();
		displayAchivmentsEarened();

	}

	public void displayAchivmentsEarened(){
		foreach( var k in MovingAchiv)
			Debug.Log("avhivment unlocked as ID "+ k.Key+ " has titile "+ k.Value.titile);

	}


	/*
	void Awake () {
		UnlockedCount = PlayerPrefs.GetInt("UnlockedCOUNT");
		lockedCount = PlayerPrefs.GetInt("Lockedcount");
		//Debug.Log(" you have unlocked " + UnlockedCount + " and you have Loced... " + lockedCount );
		//Debug.Log(PlayerPrefs.GetInt("1") + " was the achiv saved under ID 1");


		//AddAchivToList();


	}

	void Start(){
		for ( int i = 0 ; 0 < UnlockedCount ; i++) {

			x = PlayerPrefs.GetString( i.ToString() );
			 achiv.Add(x);
		}

	}


	void Update(){
		if( Input.GetKeyDown(KeyCode.Z)){
		DisplayAchivDebug();
		}

	}
	// Update is called once per frame
	public void DisplayAchivDebug(){
		for ( int i = 0 ; 0 < UnlockedCount ; i++) {
			 x = PlayerPrefs.GetString( i.ToString() );
			 Debug.Log(" unlocked " + x.ToString());
			// achiv.Add(x);
		}
			Debug.Log(" remaing loced achiv " + lockedCount.ToString());

	}

	public void AddAchivToList(){
		for ( int i = 0 ; 0 < UnlockedCount ; i++) {
			 x = PlayerPrefs.GetString( i.ToString() );
			 achiv.Add(x);
		}
			Debug.Log(" remaing loced achiv " + lockedCount.ToString());

	}

	public void DisplayText(){
		Y = GameObject.FindGameObjectWithTag("AC");
		achivTxt = Y.GetComponent<Text>();


		achivTxt.text = "";
		for ( int i = 0 ; 0 < UnlockedCount ; i++) {
			 x = PlayerPrefs.GetString( i.ToString() );
			 Debug.Log(" unlocked " + x.ToString());
		}

		achivTxt.text = " unlocked :" + x + "\n";




	}


	void ListUnlokced(){
		for ( int i = 0 ; 0 < UnlockedCount ; i++) {
			string x = PlayerPrefs.GetString( i.ToString() );
			
		}
	}
	/* 
	*/
}
