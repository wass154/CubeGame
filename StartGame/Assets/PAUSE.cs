using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PAUSE : MonoBehaviour
{
    public bool pause=false;
    public GameObject pausemenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetButtonDown("Cancel")){
        if(pause==false){
            Time.timeScale=0;
            pause=true;
            Cursor.visible=true;
            pausemenu.SetActive(true);
        }
        else{
            pausemenu.SetActive(false);
            Cursor.visible=false;
            pause=false;
            Time.timeScale=1;
        }
       } 
    }
}
