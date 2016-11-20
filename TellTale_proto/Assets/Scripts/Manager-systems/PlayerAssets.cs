using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class PlayerAssets : MonoBehaviour {

/// <summary>
/// add METHOD TO INCRASE PROFIT UNDER PLAYER GOLD TINGS 
/// </summary>
	public int gold = 300;
	public int startGold; 
	FameSystem TavernFameState;

	//values can be played with this is just a counter and a max value to be sold per day 
	int bevCounter = 0, MaxSellBearDay = 3;
	int breadCounter = 0, maxSellBreadDay = 2;
	int meatCounter = 0, maxSellMeatDay = 3;

	int ExtraProfit;
	public  List<Item> myitems = new List<Item>(); 
	public List<Item> soldItems = new List<Item>(); //have to clear it 
	public List<Item> expiredItems = new List<Item>();
			List<Item> tempBeer = new List<Item>();

	//public List<string> itemsSoldDay = new List<string>();//used to temporary store the title 
	//public List<int> pricesOfItems = new List<int>(); //used to temp store the price 
//	public List<string> brewItems = new List<string>() ;//used to store the names for refrences
	//updates used for testing... 

	//temporary going to move this to itsown script if need be 
	public Text endofDaySale;
	public Text endofdayGold;

	string mystring = "item: ";
	string soldFor ="price: ";

	AchivmentsTest test;

	TempStock tmp; 
	void Awake(){
		startGold = gold; //to calculate profits from the bening 
		TavernFameState = FindObjectOfType<FameSystem>();

	}

	void Start(){
		test = FindObjectOfType<AchivmentsTest>();

	}
	void Update(){
		if(Input.GetKeyDown(KeyCode.N)){
				Debug.Log("end of day sale");
				//sellItems();
				//sellItemsquality();

		}


		//make it rain achivment 
		if (gold >500){
			test.addEarnedAchiv(333);
			//AchivmentsTest.achivmentsTest.addEarnedAchiv(333);
		}

	}

	//this method is called from items when ever we buy we add that item to tne list of items here called myitems
	public void addItem( Item _item){

		//might remove later 
		myitems.Add(_item);

	//	Item newItem = _item;
		//if(_item.itemType == Item.ItemType.brew){

		//	brewItems.Add(_item.titile);
		//}

	}

	public void DisplayItems(){

		foreach (Item i  in myitems){

			Debug.Log(i.titile);
		}
			
	}

	//code for interactiosn 

	//we can verloas this with the thing to sell by string or better add ID value - easy to process rhan strings


//need to use this when we pdate the time 
//call this when we restart 
	public void clearItems(){

		//itemsSoldDay.Clear();
		soldItems.Clear();
		expiredItems.Clear();
		//myitems.Clear();

	}

	public void ResetVaribles(){

		maxSellMeatDay = 0;	meatCounter =  0;
		maxSellBreadDay = 0; breadCounter = 0;
		MaxSellBearDay = 0; bevCounter =0;

	}

	public void ClearItemsBought(){
		myitems.Clear();
	}
	//this is temporary gonna have to clean these up 
	//change it to npt click - will cause issue 
	/*public void DisplaySoldItems(){//string only 

		foreach (string s in itemsSoldDay) {
				 mystring = mystring.ToString() +  s.ToString() + "\n" ;
		} 

			endofDaySale.text = mystring +"\n" + gold.ToString() + "gold" ;
		endofdayGold.text = gold.ToString() + "gold";
			

	}*/

	public void DisplayinTextBar(){ //with all item values 
		//add a bool for a can click statment 
		endofDaySale.text ="";
		foreach (Item s in soldItems) {

		//dupilcate code just for testing for now 
			string x = s.ThisQuality.ToString();

				if(x == "high"){ 
					s.tempGold =  200;

				} else if ( x == "low"){
					s.tempGold = 50;

				} else{
					s.tempGold= 150;
			}
		// mystring = mystring.ToString() +  s.ToString() + "\n" ;
				mystring = mystring.ToString() + s.titile.ToString();

				soldFor = soldFor.ToString() + s.tempGold.ToString();
		} 

		endofDaySale.text = mystring +"\t" + soldFor + "gold\n"  ;

			

	}


	public  void Sell(){
		soldItems.Clear();
		SellSystem();// will generate a new list of sold items and adds them to it based on the whiteboard note 
		TheActualSelling();	//will go through the actuall list of items to be sold 
		DisplayinTextBar(); // and finnaly display it in text area 
	}



	//this is the basic sell system that was mentioned based on selling per day 
	//this is just to add it to a list of items being sold   - will not calcualte the profits here 
	// note to self: this is superlong - needs to get refactored... 
	public void  SellSystem(){
		//reset values to 0 before adding up new counters 
		ResetVaribles();
		 GetBarStatus(); //this will increase the max sell day for each one of them 
		 //after determing the max sell rate( if any is added) it iwll loop through 'my items' list of all items boght
		for (int i = 0; i< myitems.Count; i++){
				
				if(myitems[i].itemType == Item.ItemType.brew && bevCounter <= MaxSellBearDay)
				{ //in this case 3 per day 
								bevCounter++; //incread the counter - max sell date will be the 20% base of single day 


						if(myitems[i].ThisQuality == Item.quality.high && bevCounter  < 2) //numbers are for max high of drinks to be sold
								{

									soldItems.Add(myitems[i]);

						}else if (myitems[i].ThisQuality == Item.quality.mid && bevCounter < 1){

									soldItems.Add(myitems[i]);
							}
						else if (myitems[i].ThisQuality == Item.quality.low && bevCounter < 2) {

									soldItems.Add(myitems[i]);	

							}

					

				} //end of first if - code to sell brew 
				//else if the item tupe was meat and not brew and we can sell meat for the day ( max limit has not been reached)
				else if(myitems[i].itemType == Item.ItemType.meat && meatCounter <= maxSellMeatDay){ //in this case 3 per day 
					
					meatCounter++;
						

					if(myitems[i].ThisQuality == Item.quality.high && meatCounter  < 2)
							{
								soldItems.Add(myitems[i]);
								//for expired items 
								//delete expired > should be removed 
								expiredItems.Add(myitems[i]);
								myitems.Remove(myitems[i]);

					}else if (myitems[i].ThisQuality == Item.quality.mid && meatCounter < 1){
								soldItems.Add(myitems[i]);
								expiredItems.Add(myitems[i]);
								myitems.Remove(myitems[i]);

						}
					else if (myitems[i].ThisQuality == Item.quality.low && meatCounter < 5) {

								soldItems.Add(myitems[i]);
								expiredItems.Add(myitems[i]);
								myitems.Remove(myitems[i]);
						}

				}
				//if my item type that i bought was NOT brew Or MEAT then it is bread if that bread  has not reached max add it to sold items 

				   else if(myitems[i].itemType == Item.ItemType.bread && breadCounter <= maxSellBreadDay){ //in this case 3 per day 
					
						breadCounter++;
						

					if(myitems[i].ThisQuality == Item.quality.high && breadCounter  < 2)
							{
								soldItems.Add(myitems[i]);
								expiredItems.Add(myitems[i]);
								myitems.Remove(myitems[i]);

					}else if (myitems[i].ThisQuality == Item.quality.mid && breadCounter < 1){

								soldItems.Add(myitems[i]);
								expiredItems.Add(myitems[i]);
								myitems.Remove(myitems[i]);
						}
					else if (myitems[i].ThisQuality == Item.quality.low && breadCounter < 5) {

								soldItems.Add(myitems[i]);
								expiredItems.Add(myitems[i]);
								myitems.Remove(myitems[i]);

						}
						}// end of else if 	
			else { 
				//TODO:  if max sell items has been reached - create a new array and add expired products to it // or unsold items 
				Debug.Log("cant sell item ");
			}

	}
	//end of loop clear old list of bought items - cz items are now saved in sold items - this is temmporary 
	//until we determaine what to do further
	//after sorting and moving all emenets into a new list clear odl list for new additions on the next day 
 
//	myitems.Clear();
		keepBeer();
		myitems.Clear();
		reAddBeer();
		tempBeer.Clear();
	}
	public void keepBeer(){
	//make a temp holder for beer items and then shift them inside after clearing the list
	//add somehing to check 

		for (int i = 0; i< myitems.Count; i++){
				Debug.Log("inside beer keeper");		
			if(myitems[i].itemType == Item.ItemType.bread  || myitems[i].itemType == Item.ItemType.meat){
				Debug.Log("the item was meet or bread!");		
				//rmove this later 
				expiredItems.Add(myitems[i]);
			}
			else {
				tempBeer.Add(myitems[i]);
			} 
		}
	}

	//re add beer since it is the only thing that does not expireee
	public void reAddBeer(){
		foreach(Item i in tempBeer){
			myitems.Add(i);
		}
	}
	/// <summary>
	/// Thes the actual selling.
	///</summary>
	///used to calculate the end profit for the day by increasing the player's gold 
	/// since it will carry over we can leave it as is - but double check, issue might be present with calcualtions
	//- if anyone bothred reading these comments 
	///i commend you
	/// do we need a pprofit on day ? like a start up of how much you gaine - how much you had -  = new profit?  
	// since it is just one refrence thoughout the game not sure how it iwll lay out 

	public void TheActualSelling(){
		foreach( Item i in soldItems){

			string x = i.ThisQuality.ToString();

			if(x == "high"){ 
				gold += 200;

			} else if ( x == "low"){
				gold += 50;

			} else{
				gold += 150;
		}
	}}





	public void GetBarStatus(){

		switch(TavernFameState.tavernSatte){
			case FameSystem.TavernState.fancypants:
				increaseSellRate(4);
				break;
			case FameSystem.TavernState.high:
				increaseSellRate(3);
				break;
			case FameSystem.TavernState.mid:
				increaseSellRate(2);
				break;
		  default://if bar is low or trash 
				increaseSellRate(0);
				break;

		}

	}
	/// <summary>
	/// Increases the sell rate. of all items buy a specfic amount 
	/// </summary>
	/// <param name="extraSellItems">Extra sell items.</param>
	public void increaseSellRate(int extraSellItems){

		  this.MaxSellBearDay += extraSellItems;
		  this.maxSellBreadDay += extraSellItems;
		  this.maxSellMeatDay += extraSellItems;
	}


}

//old working methods - structure changed - look up
/*	public void sellItems(){
		//int rnd =   Random.Range(1,10);
		foreach (Item i in myitems){
		//ask team for another way - too much to sell based on item no? how about based on quality ?- easy to mange 
			if(i.titile =="brew"){
				gold += 84;
				Debug.Log("brew master sold");
				itemsSoldDay.Add(i.titile);

				myitems.Remove(i);
			
			} else 
				{
				if(i.titile =="rack of lamb"){

				gold += 84;
				Debug.Log("lamb sold");
				myitems.Remove(i);
			}
		}
	//	if( rnd >= 5){
			//
	//	}		
	}
	//add code to update items.
}*/





//sugest this approuch - eacy to manage better than comparing 20+ names to just compare based on quality 
//this case we will have three basic cases and we sell thwm ased on qulity and condition instead of name ? 
// check if memebers approve 
// we need to have a random value to add to each sale at the end f teh day based on the fame system 
	/*public void sellItemsquality(){
		int rnd =   Random.Range(1,10);

		foreach (Item i in myitems){
			string x = i.ThisQuality.ToString();
			// add bar status refrence here 
			//can have a function to set up both in  aswitch statment 

			Debug.Log("value of quality is "+ x );
		//ask team for another way - too much to sell based on item no? how about based on quality ?- easy to mange 
			if(x == "high"){ //&& whatever codition we have - sell this item 
				gold += 150;
				Debug.Log("brew master sold");
				itemsSoldDay.Add(i.titile);

				//myitems.Remove(i);
			
			} else if ( x == "low"){
				gold += 87;
				itemsSoldDay.Add(i.titile);
			//	myitems.Remove(i);
			} else{
				gold += 30;
				itemsSoldDay.Add(i.titile);
			//	myitems.Remove(i);

			}
				
		
	//	if( rnd >= 5){
			//
	//	}		
	}
	//add code to update items.
}*/

