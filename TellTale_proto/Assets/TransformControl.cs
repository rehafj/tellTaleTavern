using UnityEngine;
using System.Collections;

public class TransformControl : MonoBehaviour {


	MusicManager music;
	CurrentScenes c;
	public bool disableAfter = false;
	public void Awake(){

		music = FindObjectOfType<MusicManager>();
		c = FindObjectOfType<CurrentScenes>();
	}

	public void OnEnable(){
		c.changeSceneState();
		music.changeMusic();

	}

	public void OnDisable(){
		if(disableAfter)
		{
			Debug.Log("music stopped");
			music.stopMusic();
		}
	}
}
