using UnityEngine;
using System.Collections;

public class CurrentScenes : MonoBehaviour {

public enum SceneStaet {tavern, days, market}
 	public SceneStaet CurrentS;
 	public MusicManager music;
 	public GameObject[] scenes = new GameObject[2];
 	public bool SceneChaged= false;

 	public void Awake(){
 		music  = FindObjectOfType<MusicManager>();
 	}

 	// not effiant temp sulotion 
 	//void Update(){
 	public void changeSceneState(){

 			if( scenes[0].activeInHierarchy){

 				Debug.Log("market is active ");
				CurrentS = 	SceneStaet.market;
				Debug.Log(CurrentS.ToString());
 			} if(scenes[1].activeInHierarchy){

				//SceneChaged = true;
				CurrentS = 	SceneStaet.tavern;
				Debug.Log(CurrentS.ToString());
 				Debug.Log(" game scene 2 is active setting state");
 			}

 		}// end of change state 
 //	}

 public void Update(){

		Debug.Log(CurrentS.ToString());
 }
}
