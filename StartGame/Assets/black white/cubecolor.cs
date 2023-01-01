using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubecolor : MonoBehaviour
{
    
    public  static bool iscollide;
  public static bool ischange;
 public Rigidbody2D rb;
    public SpriteRenderer spritecube;
    // Start is called before the first frame update
    void Start()
    {
       
        rb=GetComponent<Rigidbody2D>();
       iscollide=false;
        ischange=false;
        spritecube= GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("newcolor")){
  spritecube.color=Color.red;
     ischange=true;
    
        }
        if(other.gameObject.CompareTag("collide")){
             rb.constraints = RigidbodyConstraints2D.FreezePositionX;
             iscollide=true;
        }
    }

    void OnTriggerExit2D(Collider2D other){
           if(other.gameObject.CompareTag("newcolor")){
            spritecube.color=Color.black;
             ischange=false;
    }
}
}
