using UnityEngine;
using System.Collections;

public class PlaySoundEffect : MonoBehaviour {


	public AudioClip soundEffect;
	public AudioSource audioo;
	// Use this for initialization
	void Start () {

		audioo =  GetComponent<AudioSource>();
		audioo.playOnAwake = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void PlaySound(){

		audioo.PlayOneShot(soundEffect);
	}
}
