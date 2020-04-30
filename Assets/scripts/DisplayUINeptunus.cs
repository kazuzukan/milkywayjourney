using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayUINeptunus : MonoBehaviour
{
    public string myString;
    public Text myText;
    public float fadeTime;
    public bool displayInfo;

    // Start is called before the first frame update
    void Start()
    {
        myText = GameObject.Find("title").GetComponent<Text>();
        myText.color = Color.clear;
        
    }

    // Update is called once per frame
    void Update()
    {
        FadeText();
        
    }

    void OnMouseDown()
    {
        if (displayInfo)
        {
            displayInfo = false;
        }
        else
        {
            displayInfo = true;
        }
    }

    void FadeText()
    {
        if (displayInfo)
        {
            myText.text = myString;
            myText.color = Color.Lerp(myText.color, Color.white, fadeTime * Time.deltaTime);
        }
        else
        {
            myText.color = Color.Lerp(myText.color, Color.clear, fadeTime * Time.deltaTime);
        }
    }
}
