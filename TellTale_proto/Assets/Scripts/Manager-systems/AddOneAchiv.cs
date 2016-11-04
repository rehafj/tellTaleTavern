using UnityEngine;
using System.Collections;

public class AddOneAchiv : MonoBehaviour {

public string Titile;
public string discription; 
public bool added;

	void OnEnable(){
	if(!added){
		AchivSystem achiv = new AchivSystem(Titile, true, discription);
		MyAcchivments.achivments.Add(achiv);
		added = true;
	}}
}
