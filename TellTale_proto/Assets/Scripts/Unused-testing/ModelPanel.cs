using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;

public class ModelPanel : MonoBehaviour {
	//based on a tutorial 
	//have easy acsess to the items 
	public Text displayText;
	public Image icon;

	// for simplicity  - changable later to genric 
	public Button optionOne;
	public Button optionTwo;
	public Button CancelButton;

	public GameObject modelPanelObject;


	private static ModelPanel modelPanel;

	public static ModelPanel instance(){

		if(!modelPanel){//if not assigned in inspector  find it and return it 

			modelPanel = FindObjectOfType(typeof (ModelPanel)) as ModelPanel;
			Debug.LogError("there needs to be one active modelPanel script aon a gameobject in current scene");


		}
		return modelPanel;
	}


	// yes/no/cancel funcion 
	//takes an option A  event asecond option event 

	public void Choice (string text, UnityAction optOneEven, UnityAction optTwoevent){


		OpenPanel();
		//this will use broute force 

	//what will happen when they click each one - should be attached to buttons 
	//take option one  button //take on click event 
		
		optionOne.onClick.RemoveAllListeners();
		//can add as many events as we want and listnsers to it 
		optionOne.onClick.AddListener(optOneEven);
		optionOne.onClick.AddListener(closePanel);//when it is triggred it will call the on the event 


		optionTwo.onClick.RemoveAllListeners();
		//can add as many events as we want and listnsers to it 
		optionTwo.onClick.AddListener(optTwoevent);
		optionTwo.onClick.AddListener(closePanel);//whe


		this.displayText.text = text;

		this.icon.gameObject.SetActive(false);
		optionOne.gameObject.SetActive(true);
		optionTwo.gameObject.SetActive(true);
	}


	public void OpenPanel(){

		modelPanelObject.SetActive (true);
	}

	public void closePanel(){

		modelPanelObject.SetActive (false);
	}

}
