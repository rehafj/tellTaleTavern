using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class TempStock : MonoBehaviour {

	public Text[] totalToBuyText = new Text[3];
	public static bool hasBenReset = false;
	//Text ToTal;
	//Button toBuy;
	public int totalEstimatedGold; 
	PlayerAssets Mygold;
	public int tempGold; 

	public List<Item> tempList = new List<Item>();

	public Button btn;

	public GameObject[] markets = new GameObject[3];
	
	// Use this for initialization
	void Start () {
		
		Mygold = FindObjectOfType<PlayerAssets>();
		tempGold = Mygold.gold;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void AddToInventory(){


		foreach (Item i in tempList){
			i.buyItemNew();
		}
		//clearTempList();

				}

	public void clearTempList(){

		tempList.Clear();
		//tempGold = 0;
		totalEstimatedGold =0;
		//temporary fix
		totalToBuyText[0].text = "";
		totalToBuyText[1].text = "";
		totalToBuyText[2].text = "";
	}

	//get total and check totoal -> 
	//when you click on buy 
	public void checkTotal(){
	if(btn!=null){
		if(btn.interactable ){

		tempGold = Mygold.gold;
		if( totalEstimatedGold<=tempGold){ //need to check this shoul dnot buy it but it does 
//			Debug.Log("can buy and will add");
			AddToInventory();
			clearTempList();
			test();
		}
		else {
			clearTempList();
			hasBenReset = true; //send this as a flag - it has it as update but did not catch it 
			test();
			Debug.Log("cannot buy no gold ");

		}
		hasBenReset = false;
		//disable button at end and change color 
		btn.interactable = false;

	}
	}
	}





	public void NewBuyMethod(){

		getTotalCostNew();
		if(btn!=null){
			tempGold = Mygold.gold;
		if(totalEstimatedGold<=tempGold){ //need to check this shoul dnot buy it but it does 
			AddToInventory();
			clearTempList();
			test();
		}
		else {
			clearTempList();
			test();

		}
		hasBenReset = false;
		//disable button at end and change color 

	
	}
	}


	public void clearMarket(){
		clearTempList();
			test();
			}

	//like check totoal 
	//call this in buy 
	public void getTotalCostNew(){
		totalEstimatedGold = 0;
		foreach(Item i in tempList){

			totalEstimatedGold += i.price;
		}

		int index = checkActiveMarket();
		totalToBuyText[index].text = "Buy  "+ totalEstimatedGold.ToString();
		btn = GameObject.Find("BuyGroup").GetComponent<Button>(); //ask josh about this -- refer notes below // or better to store it in the

	}

	//playerAsset.gold -= this.price;

	//when you click on calcualte 

	/// Old methods for the other bilds 
	/// </summary>
	public void test(){
		Debug.Log("test IIIIIII ");
		Item[] test = FindObjectsOfType(typeof(Item)) as Item[];
        foreach (Item i in test) {
        	Debug.Log("items in display are "+ test.Length);
            	//i.reStock(); HAVE TO DO THE SAME FOR RESTOCK on day change or something or when enables ? wont work ?
            	//maybe when -- will not work if object is not active .... how to?

            	i.resetTempStock();
				i.clear();
        }
        	}

	public void getTotalCost(){
		totalEstimatedGold = 0;
		foreach(Item i in tempList){

			totalEstimatedGold += i.price;
		}
		Debug.Log("total estimated cost  cost is"+ totalEstimatedGold.ToString());
		// if its beer display this. 
		//totalToBuyText = GameObject.FindGameObjectWithTag("t") as Text;
	//	 GameObject.FindGameObjectsWithTag("total");

	///temporary fix --- 
	//instead find this --- 
		int index = checkActiveMarket();
		totalToBuyText[index].text = "Buy  "+ totalEstimatedGold.ToString();
	//	totalToBuyText[1].text = "Buy  "+ totalEstimatedGold.ToString();


		//code to activate button 
		btn = GameObject.Find("BuyGroup").GetComponent<Button>(); //ask josh about this -- refer notes below // or better to store it in the
		// begning and an array and check on consition ?
		btn.interactable = true;
		ColorBlock tempColor = btn.colors;
		tempColor.normalColor = Color.green;
		btn.colors = tempColor;
				//code to enable button
	}

	public void activateButton(){
		//btn.colors = Color.green;

	
	}

	public int checkActiveMarket(){
		//foreach( GameObject m in markets){
		int counter=0;
		for (int i = 0; i < markets.Length; i++){
			counter = i;
			if( markets[i].activeInHierarchy){
				
				break;
			
			}


		}
		Debug.Log("returning counter as "+ counter.ToString());
		return counter;


		}
}


//can have a place where we store the type of store we are at 
//once we are there we can choose what button to go to instead of finding it and seaching - cz this iwll search each and evry button on scene
