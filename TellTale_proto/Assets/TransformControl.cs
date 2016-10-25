using UnityEngine;
using System.Collections;

public class TransformControl : MonoBehaviour {


	MusicManager music;
	CurrentScenes c;
	public void Awake(){

		music = FindObjectOfType<MusicManager>();
		c = FindObjectOfType<CurrentScenes>();
	}

	public void OnEnable(){
		c.changeSceneState();
		music.changeMusic();

	}

	public void OnDisable(){

		music.stopMusic();
		
	}
}
