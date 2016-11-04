using UnityEngine;
using System.Collections;

public class AchivSystem : MonoBehaviour {

	public string titile;
	public bool unlocked;
	public string discription;

	public 	AchivSystem(string _tiitle, bool _unlocked, string  _discription){


		this.titile = _tiitle;
		this.unlocked = _unlocked;
		this.discription =_discription;
	}


}
