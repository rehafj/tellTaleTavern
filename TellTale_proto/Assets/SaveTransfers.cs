using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SaveTransfers : MonoBehaviour {

public PlayerAssets plrGold;
public FameSystem TavernSte;

public int Gold;
public string TavernState;

	void Start(){
		plrGold = FindObjectOfType<PlayerAssets>();
		TavernSte = FindObjectOfType<FameSystem>();
		Gold = plrGold.gold;
		TavernState = TavernSte.getStateInString();

	}


	public void Update(){
		if(Input.GetKeyDown(KeyCode.C)){
		Transfers();
		Debug.Log("getting god"+ Gold.ToString());
		Debug.Log("getting ttavern state"+TavernState);
		}
	}

public void Transfers(){

	Gold = plrGold.gold;
	TavernState = TavernSte.getStateInString();
	PlayerPrefs.SetInt ("GOLD", Gold);
	PlayerPrefs.SetString("STATE", TavernState);
}

public void moveToNextScene(string sceneTitile){

		Debug.Log("loading scene");

		SceneManager.LoadScene(sceneTitile);

}
}
