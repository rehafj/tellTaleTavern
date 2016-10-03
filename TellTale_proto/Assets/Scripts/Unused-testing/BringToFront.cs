using UnityEngine;
using System.Collections;

public class BringToFront : MonoBehaviour {

//this will handle bringing GUI elements to the front view 

 void OnEnable(){
 	//whenever we enable this script - take the transform and set it as last sibbling 
 	//make this the last child for this layer - draw on top //draw on top cz its last 
 	transform.SetAsLastSibling();

 }
}