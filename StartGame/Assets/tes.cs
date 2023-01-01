using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tes : MonoBehaviour
{
    public float speed;
    public bool canTranslate;

    // Start is called before the first frame update
    void Start()
    {
      canTranslate=true;
    }

    // Update is called once per frame
    void Update()
    {
        //if video complete make variable in onther scene that renfrence to scene complete and make move here

       if(canTranslate){
 transform.Translate(Vector2.left * Time.deltaTime*speed);
       }
                 
      
    }
    void OnCollisionEntr2D(Collision2D other){
        if(other.gameObject.tag=="edge"){  
            print("hit");
            canTranslate=false;
        }
    }
}
