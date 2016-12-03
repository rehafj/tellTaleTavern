using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour
{


    public AudioSource m;
    public AudioClip[] backgrounds = new AudioClip[8];

    public FameSystem fame;
    CurrentScenes sceneState;
    TimeSystem time;


    public bool notChanged = true;

    void Awake()
    {
        //			clip.playOnAwake = false;
        m = GetComponent<AudioSource>();
        time = FindObjectOfType<TimeSystem>();
        m.playOnAwake = false;
        sceneState = FindObjectOfType<CurrentScenes>();
        fame = FindObjectOfType<FameSystem>();
    }


    //to send in a specfic clip if needed 
    public void PlayAudioClip(AudioClip sentclip)
    {

        m.playOnAwake = false;
        m.Stop();
        m.clip = sentclip;
        m.Play();

    }



    public void changeMusic()
    {


        m.Stop();
        Debug.Log("called music chnage");
        if (sceneState.CurrentS == CurrentScenes.SceneStaet.market)
        {
			m.clip = SetmusicByDay();
            Debug.Log("Market music should be plaing");
			m.Play();
            notChanged = false;
//day2 = 1; day3 = 3; day4 = 4; day5 = 7;


        }
        if (sceneState.CurrentS == CurrentScenes.SceneStaet.tavern)
        {
            Debug.Log("Home music  music should be plaing");

			if (FameSystem.TavernState.high == fame.tavernSatte || FameSystem.TavernState.fancypants == fame.tavernSatte) 
            {


                m.clip = backgrounds[5];
                m.Play();
                notChanged = false;

                //play music for high or fancy 
            }
			if (FameSystem.TavernState.trash == fame.tavernSatte)
            {

                m.clip = backgrounds[6];
                m.Play();
                notChanged = false;

            }
            else
            {


                m.clip = backgrounds[2];
                m.Play();
                notChanged = false;
            }
        }


    }




    public void stopMusic()
    {
        //add checko if si playing
        if(m!=null){
        m.Stop();
    }}


	public AudioClip SetmusicByDay(){

		switch( time.day){

			case 0: 
				Debug.Log("playing music of day one ");
          	  return  backgrounds[0];

          	case 1: 
				Debug.Log("playing music of day two ");
				return  backgrounds[1];

			case 2: 
				return  backgrounds[3];
			case 3: 
				return  backgrounds[4];
			default:
				return  backgrounds[7];

          		
				
		}


	}

}