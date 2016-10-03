using UnityEngine;
using System.Collections;
using Fungus;
//this will be used with the main narrative UI element 
//used to move between flow charts - same static backgrounds 
//other things like images is from fungus 
//this is just to control the flow based on time

public class EnabeFlowChart : MonoBehaviour {
	//public Flowchart FL;
	public GameObject[] flowcharts = new GameObject[4];//set these in the inspector 
	// size is = to the number of total days ( 5 for now ) better have it capped and refrence it for the futrue 
	public TimeSystem _time;

	public void Awake(){
	_time = FindObjectOfType<TimeSystem>();
	}
	public void OnEnable(){
		//FL.gameObject.SetActive(true);
		switch(_time.day){
			case 0:{
			flowcharts[0].gameObject.SetActive(true);//day 0 is related to flow chart one 
			//this is set in the inspector 
			break;
			}case 1:{
			flowcharts[1].gameObject.SetActive(true);//day 0 is related to flow chart one 
			//this is set in the inspector 
			break;
			}case 2:{
			flowcharts[2].gameObject.SetActive(true);//day 0 is related to flow chart one 
			//this is set in the inspector 
			break;
			}case 3:{
			flowcharts[3].gameObject.SetActive(true);//day 0 is related to flow chart one 
			//this is set in the inspector 
			break;
			}case 4:{
			flowcharts[4].gameObject.SetActive(true);//day 0 is related to flow chart one 
			//this is set in the inspector 
			break;
			}
			default:{
				flowcharts[4].gameObject.SetActive(true);//day 0 is related to flow chart one 
				break;
			}

		}
	}

	}
