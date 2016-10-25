using UnityEngine;
using System.Collections;

public class DisableFlowCharts : MonoBehaviour {

	public GameObject[] flowcharts = new GameObject[4];//set these in the inspector 
	// size is = to the number of total days ( 5 for now ) better have it capped and refrence it for the futrue 

	public void DisableFlowChart(int day){

		switch(day){ //disableThe prevous flow chart - cz this is updated as day goes forward 
			//each day disables the flow chart before it...

			case 0:{
			flowcharts[0].gameObject.SetActive(false);//day 0 is related to flow chart one 
			//this is set in the inspector 
			break;
			}case 1:{
			flowcharts[1].gameObject.SetActive(false);//day 0 is related to flow chart one 
			//this is set in the inspector 
			break;
			}case 2:{
			flowcharts[2].gameObject.SetActive(false);//day 0 is related to flow chart one 
			//this is set in the inspector 
			break;
			}case 3:{
			flowcharts[3].gameObject.SetActive(false);//day 0 is related to flow chart one 
			//this is set in the inspector 
			break;
			}case 4:{
			flowcharts[4].gameObject.SetActive(false);//day 0 is related to flow chart one 
			//this is set in the inspector 
			break;
			}
			default:{
				flowcharts[5].gameObject.SetActive(false);//day 0 is related to flow chart one 
				break;
			}

		

	}
	//dont worry 
	}
}
