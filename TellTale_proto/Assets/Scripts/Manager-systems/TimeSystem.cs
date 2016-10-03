﻿using UnityEngine;
using System.Collections;

public class TimeSystem : MonoBehaviour {

	public static TimeSystem _instance;
	public DisableFlowCharts fl;
	public int Hour=0;
	public  int day=0;														
	public  float min=0;
	public static int _day = 0; 

	//add a camera object and have it move when day restes to top scene or view // have it black out camera and then back on 


	// if we will use diffrent scenes ( need this ) if not remove.
	/// <summary>
	/// Awake this instance.
	/// a singlton pattern so time presits across scenes if chosen
	/// </summary>
	void Awake()
        {
        fl = FindObjectOfType<DisableFlowCharts>();

		if (_instance == null)

			_instance = this;
            
		else if (_instance != this)
                
				//dESTROY COPY
                Destroy(gameObject);    
    
            // and do not destory current time objects
            DontDestroyOnLoad(gameObject);
            
          
        }

	//for testing only - remove later 
	/*
	public void Update(){

			if(Input.GetKeyDown(KeyCode.Space)){
				Debug.Log("updating time by 30 min");
				updateTime(30f);
				printCurrentTime();
			}
	}
	*/

	//debugging purposes 
	public void printCurrentTime(){

			Debug.Log("time is day:"+day+" hour: "+ this.Hour + "min is "+ this.min);
			
	}


	/// <summary>
	/// Updates the time.
	/// </summary>
	/// <param name="_min">takes in parm minutes value - updates based on min sent over</param>
	public void  updateTime(float _min ){
			//note no carry over min - set time appropritle (15-30-45)..etc
			//for simplicity
			if(this.min <= 59 ){

				this.min +=  _min;
	}
			else {
				this.min = 0;
				//hour was based on 11 for now changed to 3 just to cycle through the days
				if(this.Hour<=2){
					Debug.Log("Adding an hour");
					this.Hour +=   1;

					}
				 if(this.Hour>2){
						Debug.Log("hour greater than 3");

					}


				else {
					Debug.Log("am i going here");
				//when the day ends reset hour and update day bu 1
					this.Hour = 0;
					updateDay();}


			}
		printCurrentTime();

	}

	public void UpdateHour(){
		
	}

	/// <summary>
	/// Updates the day.
	///if it reaches ( 8 ori.e 7 full days ) resets time
	/// </summary>
	public void updateDay(){
	//this was 6 - ( 7days) 
			if(this.day <=4)
					
			{
				fl.DisableFlowChart( this.day);
				this.day +=1;
				//method to stop fungus charts
				MoveToNext.dayChanged = true;
				Debug.Log("day changed hazah");

			}
			else
			{
				resetData();
					
			}


	}

	/// <summary>
	/// Resets all time data data.
	/// </summary>
	public void resetData(){

			this.day = 0;
			this.Hour = 0;
			this.min = 0;
	}



	//this method is to be used by the market class in order to get the day ( for avaiblity of products) 
	/// <summary>
	/// Gets the day. - fix this 
	/// </summary>
	/// <returns> returns the value of the day, not the day object manipulated here.</returns>
	public static int  getDay(){

		_day = _instance.day ;
			return(_day);

	}


	public string returnDaytoString(){

		switch(day){
			case 0:
				Debug.Log("Monday");
				return "Monday";
			case 1: 
				Debug.Log("tuesday");
				return "tuesday";
			case 2: 
				Debug.Log("Wednesday");
				return "Wednesday";
			case 3: 
				Debug.Log("tues");
				return "thursday";
			 default:
				Debug.Log("otehr days");
				return "weekdays";


		}

	}

}
