using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickmenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    //    Application.LoadLevel(0);
    }

    public void next(){
        Application.LoadLevel(1);
    }

    public void quit(){
        Application.Quit();
    }
    // Update is called once per frame
    void Update()
    {
    
    }
}
