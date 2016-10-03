using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using  System;
public class products : MonoBehaviour {



	public double sellPrice; //price on store 
	public double BasicProfitValue;
	public int stock;
	public int storeStock;
	public bool avaiblitiy;






 //at one time 4 things only 
	//stock limited in store 
	//using list to store it 


public enum productType{
		Bread,
		Meat,
		Brew

	}
	//do a method to compare what item type u had based on the statr of it...? no not good :/ scratch that ideasss

	public products(){

	}

	public virtual double calculateProfit(double multiplayer){
		double tempProfit;
		tempProfit = this.BasicProfitValue * multiplayer;
		return Math.Ceiling(tempProfit);
	}

	public virtual bool TimeAvailbility(int TimeOfDay){
	//int time of day
	//TODO: have it get an the current time value 
	//based on the time / day (1/2/3) make it avaible or not 
	//ill change int to state early game/late game / 
		return false;




	}
	public virtual bool StockAvailbility(int day_type){


			return this.avaiblitiy;
	


	}

	//will use this method to get the day from other classes such as teh market class/ products 
	public void Update(){

			if(Input.GetKeyDown(KeyCode.Space)){
				Debug.Log(" getting day value ");
				int theDay = TimeSystem.getDay();
			Debug.Log(" CURRWNT DAY IS"+ theDay );
			}
	}

	}
public class Meats: products{

	

}

public class Bread: products{}

public class Brew: products{}

//unity cloud build 
//ff system - pulling a song and chiptuning it 
//inventory system - just text 