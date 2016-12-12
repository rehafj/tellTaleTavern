using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Loading : MonoBehaviour {

	//siome partys are based on a  totorial by Abhinav (a.k.a Demkeys)
	Animator thisanimtinl;
	AsyncOperation ao;
	public GameObject laodingScreenBg;


	public bool isFakeLoaing = false;
	public float fakeIncrement = 0f;
	public float fakeTiming = 0f;
	// Use this for initialization
	void Start () {

		thisanimtinl = GetComponent<Animator>();
		thisanimtinl.Play("Test");
		loadLevelMainGame();
//		if(Application.GetStreamProgressForLevel("DayOne") ==1){
//   		 SceneManager.LoadSceneAsync("DayOne");}
			

	}
	
	// Update is called once per frame
	void Update () {



	}

	public void  loadLevelMainGame(){


	if(!isFakeLoaing){

			StartCoroutine("LoadLevelInProression");

	}
	else {

	}

	}//end of laod

	IEnumerator LoadLevelInProression(){

		yield return new WaitForSeconds(1);
		ao = SceneManager.LoadSceneAsync("DayOne");

		ao.allowSceneActivation = false;

		while(!ao.isDone){

			if(ao.progress ==0.9f){

				ao.allowSceneActivation = true;

			}

			Debug.Log(ao.progress);
			yield return null;

		}

	
	}
}
