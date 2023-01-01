using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sq : MonoBehaviour
{
    public camera cam1;
    public camera cam2;
    // Start is called before the first frame update
    void Start()
    {
          cam1.enabled = false;
     cam2.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("cube")){
            //change camera and fixed position player and set dialogue
   cam1.enabled = !cam1.enabled;
         cam2.enabled = !cam2.enabled;
         
        }
    }
}
