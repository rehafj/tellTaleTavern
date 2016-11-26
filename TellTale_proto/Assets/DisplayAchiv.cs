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
		//AddAchivToList();


	}

	void Start(){


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
