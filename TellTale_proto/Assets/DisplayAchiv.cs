using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class DisplayAchiv : MonoBehaviour {

	int UnlockedCount;
	int lockedCount;
	public Text achivTxt;
	GameObject Y;
	string x = " " ;

	List <string > achiv = new List<string>();


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

}
