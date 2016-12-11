using UnityEngine;
using System.Collections;

public class DayOneMusicManager : MonoBehaviour {

	// Use this for initialization

    public AudioSource m;
    public AudioClip[] backgrounds = new AudioClip[10];

    public FameSystem fame;
    CurrentScenes sceneState;




    public bool notChanged = true;
	bool visted = false;

    void Awake()
    {
        //			clip.playOnAwake = false;
        m = GetComponent<AudioSource>();
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


      
        Debug.Log("called New Music Manager");
        if (sceneState.CurrentS == CurrentScenes.SceneStaet.market && visted==false)
        {
			SetmusicByChoice(0);
            notChanged = false;
			visted=true;

            // 0 for market 
        }
        if (sceneState.CurrentS == CurrentScenes.SceneStaet.tavern)
		{  m.Stop();
            Debug.Log("Home music  music should be plaing");

			if (FameSystem.TavernState.high == fame.tavernSatte || FameSystem.TavernState.fancypants == fame.tavernSatte) 
            {

				SetmusicByChoice(1);  // oen for high or or up states 
				 notChanged = false;
            }
			if (FameSystem.TavernState.mid == fame.tavernSatte)
            {
         		SetmusicByChoice(2); //SEND IN SETTINGS FOR MID 
                notChanged = false;

            }
            else
            {	
            	SetmusicByChoice(3);
                notChanged = false;
            }
        }   }




    public void stopMusic()
    {
        //add checko if si playing
        if(m!=null){
        m.Stop();
    }}


    /// <summary>
    /// 
    /// </summary>
    /// <returns>The by randomly.</returns>
    /// <param name="selectPlace">Send 0 for market, 1 , 2, 3</param>
    /// case 0 -> send market index - case 1: high or above - case2: mid - others - send in 
	public void  SetmusicByChoice(int selectPlace){

		switch( selectPlace){

			case 0: 
				Debug.Log("Music was set to  - changing to market");
				sendMusicClips(0,1);
          	  	break;

          	case 1: 
				Debug.Log("Music was set to high or above");
				sendMusicClips(2,3,4);
				break;

			case 2: 
				Debug.Log("Music was set to mid or above");
				sendMusicClips(5,6,7);
				break;
			default:
				Debug.Log("Music was Low or trash ");
				sendMusicClips(8,9);
				break;
          		
				
		}


	}

	//send number of clips through script 
	//this is used for fancy and midum 
	public void sendMusicClips(int clip1, int clip2, int  clip3){
		int rnd = Random.Range(0,3);
		Debug.Log("random was set to "+ rnd.ToString() +"");

		if( rnd == 0 ){

			m.clip = backgrounds[clip1];
            m.Play();
		}
		if( rnd == 1 ){

			m.clip = backgrounds[clip2];
            m.Play();
		}
		else {
			m.clip = backgrounds[clip3];
            m.Play();

		}
	}

	//overlaoded method - send clips for trash and market as param 
	public void sendMusicClips(int clip1, int clip2){
		int rnd = Random.Range(0,2);


		if( rnd == 0 ){

			m.clip = backgrounds[clip1];
            m.Play();
		}
	
		else {
			m.clip = backgrounds[clip2];
            m.Play();

		}
	}



}
