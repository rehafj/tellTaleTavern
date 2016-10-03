using UnityEngine;
using System.Collections;

public class EnableChildren : MonoBehaviour {

	// Just a quick fix to a problelm 
	void OnEnable(){
	for (int i = 0; i < this.transform.childCount; ++i)
 {
     this.transform.GetChild(i).gameObject.SetActive(true);
     }}}
 