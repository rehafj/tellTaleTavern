using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class uijiggle : MonoBehaviour {
    public GameObject button;
    public SpriteRenderer flashingRenderer;
    Color initial;
    Color flash = new Color (1f,1f,1f,.75f);
    int waitVar;
    bool pause = true;
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
            if (pause == true)
            {
                waitVar = Random.Range(1, 6);
                for (int i = 1; i < waitVar; i++)
                {

                }
                pause = false;
            }
           this.flashingRenderer.color = flash;
            yield return new WaitForSeconds(.5f);
            //display original color for the next 0.5 seconds
            this.flashingRenderer.color = this.initial;
            yield return new WaitForSeconds(1f);
        }
    }

}
