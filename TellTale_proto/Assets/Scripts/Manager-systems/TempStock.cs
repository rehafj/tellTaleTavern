using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class TempStock : MonoBehaviour {

	public Text[] totalToBuyText = new Text[3];
	public bool hasBenReset = false;
	//Text ToTal;
	//Button toBuy;
	public int totalEstimatedGold; 
	PlayerAssets Mygold;
	public int tempGold; 

	public List<Item> tempList = new List<Item>();
	
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
	}


	//when you click on buy 
	public void checkTotal(){
		tempGold = Mygold.gold;
		if( totalEstimatedGold<=tempGold){ //need to check this shoul dnot buy it but it does 
			Debug.Log("can buy and will add");
			AddToInventory();
			clearTempList();
			test();
		}
		else {
			clearTempList();
			hasBenReset = true;
			test();
			Debug.Log("cannot buy no gold ");

		}
		hasBenReset = false;
	}

	//playerAsset.gold -= this.price;

	//when you click on calcualte 
	public void test(){
		Debug.Log("test IIIIIII ");
		Item[] test = FindObjectsOfType(typeof(Item)) as Item[];
        foreach (Item i in test) {
            	//i.reStock(); HAVE TO DO THE SAME FOR RESTOCK on day change or something or when enables ? wont work ?
            	//maybe when -- will not work if object is not active .... how to?
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
		totalToBuyText[0].text = "Buy  "+ totalEstimatedGold.ToString();
	}


}


