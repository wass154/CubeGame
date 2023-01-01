using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edg : MonoBehaviour
{
public static bool sha;
      public float speed;
    public bool canTranslate;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        sha=false;
        rb=GetComponent<Rigidbody2D>();
        canTranslate=true;
        rb.gravityScale=0;

    }

    // Update is called once per frame
    void Update()
    {
      if(canTranslate)
 transform.Translate(Vector2.left * Time.deltaTime*speed);
       
                 
    }
    void OnCollisionEnter2D(Collision2D collision)
   {
        if(collision.gameObject.tag == "edge"){  
sha=true;
print(sha);
            print("hit");
            canTranslate=false;
            rb.gravityScale=1;
        }
    }
    
    
}
