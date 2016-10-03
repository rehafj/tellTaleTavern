using UnityEngine;
using System.Collections;

public class TheMarket : MonoBehaviour {

//	public TheMarket [] test;

	
	public string[]  titile = new string []{
		"titile A", 
		"TITILE B",
		"TITILE C"

	};
	 public string[] discription = new string[]{
	 "yum",
	 "no",
	 "another temp"

	 }; 
	
	public TheMarket(string _titile, string dis){

		//this.titile = _titile;
		//.discription = dis;
	}
	public int stock;//stock in storeTy
	public int price ;
	public enum quality { high, mid, low}

	public virtual void Awake(){
	//	TheMarket [] test = new TheMarket[2];
		for ( int i=0; i<=2; i++){
			
			//test[i] = new TheMarket(titile[i],discription[i]);
			
		}
		//Debug.Log(test[1]);
	}
	public virtual void  Update(){

	//this one works but doesnt on gui why!!! - check it out when it is not around 3 am :) 

	if(Input.GetKeyDown(KeyCode.Space)){
				Debug.Log(" getting day value ");
				int theDay = TimeSystem.getDay();
			Debug.Log(" CURRWNT DAY IS"+ theDay );
			}
	}


	public virtual void setItemData(int quality){

		switch(quality){

		//case quality.high:
		case 1:
			this.stock = 3;
			this.price = 100;
			break;
		case 2:
			this.stock = 6;
			this.price = 50;
			break;
		 default :
			this.stock = 10;
			this.price = 10;
			break;
	}


}
}