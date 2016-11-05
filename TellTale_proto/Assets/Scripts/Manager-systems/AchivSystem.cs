using UnityEngine;
using System.Collections;


//the actual achivment 
public class AchivSystem : MonoBehaviour {

	public string titile;
	public bool unlocked;
	public string discription;
	public int points;

	//old constructor 
	public 	AchivSystem(string _tiitle, bool _unlocked, string  _discription){


		this.titile = _tiitle;
		this.unlocked = _unlocked;
		this.discription =_discription;
	}



	//overloaded const for new achiv system 
	//iff needed adda achiv system 
	public 	AchivSystem(string _tiitle, bool _unlocked, string  _discription, int _points){



		this.titile = _tiitle;
		this.unlocked = _unlocked;
		this.discription =_discription;
		this.points = _points;
	}


	public bool unlockAchiv(){

			if(!this.unlocked){
					this.unlocked = true;
					SaveAchic(unlocked);

					return true;
			


			}
		
					return false;
					
			
	}


	public void SaveAchic(bool state){

			int temp = PlayerPrefs.GetInt("TotalPoints");
			PlayerPrefs.SetInt("TotalPoints", temp +=this.points);
			if(state == true){

			PlayerPrefs.SetInt(titile, 1);//trueaor earned and later check if 1 is earned
			}
			else {
				PlayerPrefs.SetInt(titile,0);
			}

			PlayerPrefs.Save();


	}


	//create soemthing to load it using player prefs and check if it ha been laoded or nto 
	// 

}
