using UnityEngine;
using System.Collections;
using Fungus;
public class EventManagerFungus : MonoBehaviour {

	// int today = TimeSystem._day; NEVER CHANGES NOTICE IT !!!

	[SerializeField]
	FameSystem currentFame;
	TimeSystem currentTime;
	PlayerAssets inventory;
	// Use this for initialization
	void Awake () {

		currentFame = FindObjectOfType<FameSystem>();
		currentTime = FindObjectOfType<TimeSystem>();
		inventory = FindObjectOfType<PlayerAssets>();
	}
/*	public void Update(){
		 int today = TimeSystem.getDay();// NEVER CHANGES NOTICE IT 
			Debug.Log("static day is " + today.ToString());
		 //int anotehrday = currentTime.getDayInInt();
		//	Debug.Log("instance day is " +anotehrday.ToString());
	}*/

	public void WhoIsAvaibleFlow(){
		Debug.Log("messge invoked from fungus");
		string statas = currentFame.getStateInString();
		int today = TimeSystem.getDay();
		Debug.Log("day is " + today.ToString());
		SetTargetFlowChart(today, statas);
	}
	//send in a messge depending on the bar's status and day to activate certain flow charts!
	// example lady quin will nnot show up if bar's stat is high but sasha will only show up if bars status is low 
	public void SetTargetFlowChart(int day, string barStat){

		if(barStat =="fancypants"){

			Debug.Log("bar was fancy");

			if(day==1)
				Fungus.Flowchart.BroadcastFungusMessage("H2");
			if(day==2)
				Fungus.Flowchart.BroadcastFungusMessage("H3");
			if(day==3)
				Fungus.Flowchart.BroadcastFungusMessage("H4");
			if(day==4)
				Fungus.Flowchart.BroadcastFungusMessage("H5");
		}
		if(barStat =="trash"){
			Debug.Log("bar was trash");
			if(day==1)
				Fungus.Flowchart.BroadcastFungusMessage("L2");
			if(day==2)
				Fungus.Flowchart.BroadcastFungusMessage("L3");
			if(day==3)
				Fungus.Flowchart.BroadcastFungusMessage("L4");
			if(day==4)
				Fungus.Flowchart.BroadcastFungusMessage("L5");
		}
		else{
			Debug.Log("bar has another status ");
			if(day==1)
				Fungus.Flowchart.BroadcastFungusMessage("E2");
			if(day==2)
				Fungus.Flowchart.BroadcastFungusMessage("E3");
			if(day==3)
				Fungus.Flowchart.BroadcastFungusMessage("E4");
			if(day==4)
				Fungus.Flowchart.BroadcastFungusMessage("E5");
		}






	}

	//this is used to add a narrative thing near the end 
	public void BuyFromFungus(string itemToBuy){

		int cnt = 0;
		for( int i = 0 ; i <= inventory.myitems.Count-1 ;i++){

			if(inventory.myitems[i].titile == itemToBuy && cnt<=1){

				inventory.myitems.Remove(inventory.myitems[i]);
				inventory.soldItems.Add(inventory.myitems[i]);

				cnt++; 
				break;//to insure it only sells one item 
			}	
		}
	}

}
