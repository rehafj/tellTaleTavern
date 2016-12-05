using UnityEngine;
using System.Collections;

public class uijiggle : MonoBehaviour {

    GameObject uiobject;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        this.uiobject.transform.Rotate(0, 0,20); 
        this.uiobject.transform.Rotate(0, 0, 0);
        this.uiobject.transform.Rotate(0, 0, -20);
        this.uiobject.transform.Rotate(0, 0, 0);
    }
}
