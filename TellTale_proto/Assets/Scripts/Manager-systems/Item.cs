﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
/// <summary>
//TODO:  Have to refactor code - bits and parts are repeated in this class 
/// class is too bulky might seprate tasks later on if time permits (step 1: get it to work :P) 
/// </summary>
public class Item : MonoBehaviour {

//text feilds fot the market 
	public Text Button_text;  public Text txt_stock;
	public Text txt_price;	  public Text txt_textField;
//memeber varibles for ach item 
	public string  titile;			public string discription ;
	public int stock;				public int price;
	public bool isAvailable;
//type and quality set up
	public enum quality { high, mid, low}		public quality ThisQuality;

	public enum ItemType {meat, brew, bread}	public ItemType itemType;
//getting the current time system - see awake 
	public TimeSystem dayTime;	
	public int dayUnAvaible;

	public int tempGold;
	[SerializeField]
	PlayerAssets playerAsset; 
	FameSystem tavernStat;

	bool mouceEnters = false;


	//for styling gui later on ( THE BOX FLOAT THING)
	GUIStyle style = new GUIStyle();

//initilize setups 
	void Awake(){
			dayTime = FindObjectOfType<TimeSystem>();
			playerAsset = FindObjectOfType<PlayerAssets>();
			tavernStat = FindObjectOfType<FameSystem>();
			setItemData(ThisQuality);
			checkAvaiblity(dayUnAvaible);
			setupTextFeilds();

	}

	//after awake - for the box settings 
	void Start(){

		style.alignment = TextAnchor.MiddleCenter;
		style.fontSize = 26;

	}
	//method to setup text feilds 
	public void setupTextFeilds(){
			Button_text.text = "buy " + this.titile;
			txt_stock.text = "#"+ this.stock.ToString();
			txt_price.text = this.price.ToString()+"gold";
			}


	/// <summary>
	/// updates are just for testing purposes 
	/// </summary>
	void Update(){
		if(Input.GetKeyDown(KeyCode.B)){
				Debug.Log("checking avaibility");
				checkAvaiblity(dayUnAvaible);
				buyItem();

		}
	}

	//based on the item data set the price and stock - can be played and add a rnd value 
	public  void setItemData(quality qualityValue){

		switch(qualityValue){

		//case quality.high:
		case quality.high:
			this.stock = 3;
			this.price = 100;
			break;
		case quality.mid:
			this.stock = 6;
			this.price = 50;
			break;
		 default :
			this.stock = 10;
			this.price = 10;
			break;
	}

	}

	//just a temp fix 
	public  void checkAvaiblity(int unavaibleDay){
	 // add bool later 
	//	for(int i = 0; i <=unavaibleDay.Length; i ++){

				if(dayTime.day == unavaibleDay){
					//gameObject.SetActive(false);
					isAvailable = false;
			
			}
				else {
					//gameObject.SetActive(true);
					isAvailable = true;
					Debug.Log("item is avaible");
				}
		}


	public void buyItem(){
		Debug.Log("entred buy item");
		checkAvaiblity(dayUnAvaible);

		if(isAvailable && stock>0){

			if(playerAsset.gold >= this.price){
				//add a method to check item quality - if high //increase by high amount on other method 
				updateFame();
				playerAsset.gold -= this.price;
				this.stock-=1 ;
				playerAsset.addItem(this);
				Debug.Log(" you got the item"+ this.titile);

				if(txt_textField !=null){
					txt_stock.text = stock.ToString();
					txt_textField.text ="here you go, one "+this.titile+"  \n anything else dear?" ;
				}//increase BAR FAME or on player assets page 

			}
		}else if (isAvailable == false || stock <= 0){
			//GUI.Label(new Rect(10, 10, 100, 20), "Out of stock!");
				if(txt_textField !=null){
				if( isAvailable == false ){
						txt_textField.text ="sorry out of that item Today, try again another day ";
				}

				else if(playerAsset.gold<=8){

						txt_textField.text ="looks you are running short ";

				}}	Debug.Log("sorry out of that item");

		} else {
			if(txt_textField !=null){
						
						txt_textField.text =" looks liek you are short on Gold there";
						}}}



	//enter event for mouce 
	public void setEnter(){
		mouceEnters = true;
	}
	//ecit event for mouce 
	public void setExit(){
		mouceEnters = false;
	}


	//this method updates Fame of the bar based on  item stat
	public void updateFame(){
		switch(ThisQuality){
			case (quality.high):
				tavernStat.ChangeStateBare(30);
				break;
			case (quality.mid):
				tavernStat.ChangeStateBare(0);
				break;
			default:
				tavernStat.ChangeStateBare(-15);
				break;
		}
			
	}

	//TODO: 
		//gui events 
		//this method os not needed ... 
	/*void OnCLick(){
			checkAvaiblity(dayUnAvaible);
			buyItem();
		}*/
	//to draw the box if mouce event is true 
	void OnGUI()
		 {
		if(mouceEnters == true){
				//have to play with these values 
			GUI.Box(new Rect(Screen.width/2 -200 ,Screen.height/2, Screen.width/4, Screen.height/4), this.discription);
				//GUI.Label(new Rect(100,100,200,30),this.discription);
				}
		 }
		 /*
	void OnMouseOver()
		{
	    	_mouseOver = true;
		}
	void OnMouseExit()
		{
	   	 _mouseOver = false;
		}


	void OnEnable(){
			//checkAvaiblity(dayAvaible);
	}
	*/


	}

