using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class col2 : MonoBehaviour
{
    public Camera camera1;
     public Camera camera2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerExit2D(Collider2D other){
        camera1.enabled = true;
         camera2.enabled = false;
    }
}
