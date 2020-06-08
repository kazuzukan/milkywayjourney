using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayUIMars : MonoBehaviour
{
    // public string stringTitle;
    public Canvas displayUI;
    public MeshRenderer moon;
    public float fadeTime;
    public bool displayInfo;

    // Start is called before the first frame update
    void Start()
    {
        displayUI = GameObject.Find("displayUIMars").GetComponent<Canvas>();
        moon = GameObject.Find("moon").GetComponent<MeshRenderer>();
        moon.enabled = false;
        displayUI.enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    public void displayTheUI()
    {
        displayUI.enabled = !displayUI.enabled;
    }

    public void displayMoon()
    {
        moon.enabled = !moon.enabled;
    }

    /* void OnMouseOver()
    {
        displayUI.enabled = true;
    }

    void OnMouseExit()
    {
        displayUI.enabled = false;    
    }
    */

}
