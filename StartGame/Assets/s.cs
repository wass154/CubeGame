using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s : MonoBehaviour
{
    public Camera camera1;
     public Camera camera2;
   

    // Start is called before the first frame update
    void Start()
    {
        camera1.enabled=false;
        camera2.enabled=true;
    
    }

    // Update is called once per frame
    void Update()
    {
      
    }
     void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("cube")){
            //change camera and fixed position player and set dialogue
   camera1.enabled = !camera1.enabled;
         camera2.enabled = !camera2.enabled;
   
}
else{
             camera1.enabled = !camera1.enabled;
         camera2.enabled = !camera2.enabled;
     
}

        }
       
       
       
    }
    
 
    

