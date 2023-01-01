using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Y : MonoBehaviour
{
         public static bool isyellow;
    public GameObject yellowplace;
     public Rigidbody2D rb;
     public float speed=5f;
    // Start is called before the first frame update
    void Start()
    {
        isyellow=false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("y")){
             //Vector2 newPos = Vector2.Lerp(this.transform.position, blueplace.transform.position, Time.deltaTime * speed);
this.transform.position=yellowplace.transform.position;
rb.constraints = RigidbodyConstraints2D.FreezePositionX;
print("yellow hit");
isyellow=true;
        }
    }
}
