using UnityEngine;
using System.Collections;

public class TransformControl : MonoBehaviour {


	MusicManager music;
	DayOneMusicManager newmusic;
	CurrentScenes c;
	public bool disableAfter = false;
	public void Awake(){

		music = FindObjectOfType<MusicManager>();
		newmusic =FindObjectOfType<DayOneMusicManager>();
		c = FindObjectOfType<CurrentScenes>();
	}

	public void OnEnable(){
		c.changeSceneState();

		if(music!=null){ //for old one 
			Debug.Log("Global music manager");
			music.changeMusic();}

		//for the new music manager ( limted to day one) 
		if(newmusic!=null){

			Debug.Log("Day one limited music");
			newmusic.changeMusic();

		}
	}

	public void OnDisable(){
		if(disableAfter)
		{
			Debug.Log("music stopped");
//			music.stopMusic();
		}
	}
}
