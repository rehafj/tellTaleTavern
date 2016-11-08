using UnityEngine;
using System.Collections;

public class EndScene : MonoBehaviour {

	 int gold;
	 string TavernSTate;

// Use this for initialization
void Awake () {    
		gold = PlayerPrefs.GetInt ("GOLD");
		TavernSTate = PlayerPrefs.GetString("STATE");

		Debug.Log("gold is "+ gold);
		Debug.Log("state  is "+ TavernSTate);
		}



public void fungusEndCall(){	

	if( TavernSTate == "fancypants" ||  TavernSTate =="high"){

		SetBlock(gold ,3 );

	}
	else if ( TavernSTate=="mid"){

		SetBlock(gold ,2 );


	}
	else {
			SetBlock(gold ,1 );

	}



}

	public void SetBlock(int _gold, int rating){

		if( _gold > 0) {

			switch(rating){
				case 3:
					Fungus.Flowchart.BroadcastFungusMessage("H");//CALL TO block that excutes money + 
					break;

				case 2:
					Fungus.Flowchart.BroadcastFungusMessage("M");
					break;

				default:
					Fungus.Flowchart.BroadcastFungusMessage("L");
					break;
				
			}
			//check for states 
	


		} else {

			Fungus.Flowchart.BroadcastFungusMessage("FAIL");
	
		}



		
		}

}
