using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideSpeed : MonoBehaviour
{
    public int i;
  
    // Start is called before the first frame update
    void Start()
    {
        i=0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("cube") && i==0){
            white.speed=8f;

        }
    }
     void OnTriggerExit2D(Collider2D other){
        if(other.gameObject.CompareTag("cube")){
          white.speed=5f;
          i++;
          
            
        }
    }
}
