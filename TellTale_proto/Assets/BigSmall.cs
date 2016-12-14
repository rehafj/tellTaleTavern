using UnityEngine;
using System.Collections;

public class BigSmall : MonoBehaviour {
public Transform originalSize;
Transform newSize;
//public GameObject shopItem;

	// Use this for initialization
	void Start () {
        originalSize = this.transform;
       

    }
	
	// Update is called once per frame
	void Update () {
	
	}
   public void Expand()
    {
        this.newSize.transform.localScale = (this.originalSize.localScale += new Vector3(0.3F, 0.3F, 0.3F));
        this.transform.localScale = newSize.localScale;
    }
    public void Contract()
    {
        this.newSize.transform.localScale =(this.originalSize.localScale);
        this.transform.localScale = newSize.localScale;
    }
} 