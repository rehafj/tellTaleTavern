using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour
{


    public AudioSource m;
    public AudioClip[] backgrounds = new AudioClip[5];

    public FameSystem fame;
    CurrentScenes sceneState;


    public bool notChanged = true;

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


        m.Stop();
        Debug.Log("called music chnage");
        if (sceneState.CurrentS == CurrentScenes.SceneStaet.market)
        {
            Debug.Log("Market music should be plaing");

            m.clip = backgrounds[0];
            m.Play();
            notChanged = false;

        }
        if (sceneState.CurrentS == CurrentScenes.SceneStaet.tavern)
        {
            Debug.Log("Home music  music should be plaing");

            if (FameSystem.TavernState.high == fame.tavernSatte)
            {


                m.clip = backgrounds[1];
                m.Play();
                notChanged = false;

                //play music for high or fancy 
            }
            if (FameSystem.TavernState.trash == fame.tavernSatte)
            {

                m.clip = backgrounds[1];
                m.Play();
                notChanged = false;

            }
            else
            {


                m.clip = backgrounds[1];
                m.Play();
                notChanged = false;
            }
        }


    }




    public void stopMusic()
    {
        //add checko if si playing
        m.Stop();
    }

}