using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class uijiggle : MonoBehaviour {
    GameObject button;
    SpriteRenderer flashingRenderer;
    Color initial;
    Color flash = new Color (1f,1f,1f,0f);

    void Start()
    {
        this.flashingRenderer = this.button.GetComponent<SpriteRenderer>();
        this.initial = this.flashingRenderer.color;
        //Call coroutine BlinkText on Start
        StartCoroutine(BlinkRender());
    }

    //function to blink the image 
    public IEnumerator BlinkRender()
    {
        //blink it forever. You can set a terminating condition depending upon your requirement
        while (true)
        {
          
           this.flashingRenderer.color = flash;
            yield return new WaitForSeconds(.5f);
            //display original color for the next 0.5 seconds
            this.flashingRenderer.color = this.initial;
            yield return new WaitForSeconds(.5f);
        }
    }

}
