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

	//caall this method to save it into this dictionary 
	public void SaveAchivmAcrossScenes(){
		achivStrings.Clear();
		achivStrings = myAchivments.GetAchivmentsAsString();

	}
	public void SaveAchivAcrossScenes(){
		MovingAchiv.Clear();//this may produce a bug
		MovingAchiv = myAchivments.GetAchivmentsAsAchiv();

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
