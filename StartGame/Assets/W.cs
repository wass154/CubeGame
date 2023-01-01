using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W : MonoBehaviour
{
      public static bool iswhite;
    public GameObject whiteplace;
     public Rigidbody2D rb;
     public float speed=5f;
    // Start is called before the first frame update
    void Start()
    {
         iswhite=false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("w")){
             //Vector2 newPos = Vector2.Lerp(this.transform.position, blueplace.transform.position, Time.deltaTime * speed);
this.transform.position=whiteplace.transform.position;
rb.constraints = RigidbodyConstraints2D.FreezePositionX;
print("white hit");
iswhite=true;
        }
    }
}
