using UnityEngine;
using System.Collections;

public class AmbienceManager : MonoBehaviour
{


    public AudioSource a;
    public AudioClip[] ambience = new AudioClip[3];

    public FameSystem fame;
    CurrentScenes sceneState;


    public bool notChanged = true;

    void Awake()
    {
        //			clip.playOnAwake = false;
        a = GetComponent<AudioSource>();
        a.playOnAwake = false;
        sceneState = FindObjectOfType<CurrentScenes>();
        fame = FindObjectOfType<FameSystem>();
    }


    //to send in a specfic clip if needed 
    public void PlayAudioClip(AudioClip sentclip)
    {

        a.playOnAwake = false;
        a.Stop();
        a.clip = sentclip;
        a.Play();

    }



    public void changeMusic()
    {


        a.Stop();
        Debug.Log("called ambience chnage");
      
        if (sceneState.CurrentS == CurrentScenes.SceneStaet.tavern)
        {
            Debug.Log("Ambience should be plaing");

            if (FameSystem.TavernState.high == fame.tavernSatte)
            {


                a.clip = ambience[1];
                a.Play();
                notChanged = false;

                //play music for high or fancy 
            }
            if (FameSystem.TavernState.trash == fame.tavernSatte)
            {

                a.clip = ambience[2];
                a.Play();
                notChanged = false;

            }
            else
            {


                a.clip = ambience[0];
                a.Play();
                notChanged = false;
            }
        }


    }




    public void stopMusic()
    {
        //add checko if si playing
        if(a!=null){
        a.Stop();
    }}

}