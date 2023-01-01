using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class red : MonoBehaviour
{
    public static bool  isred;
     public GameObject redplace;
     public Rigidbody2D rb;
     public float speed=5f;
    // Start is called before the first frame update
    void Start()
    {
        isred=false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("r")){
            // Vector2 newPos = Vector2.Lerp(this.transform.position, redplace.transform.position, Time.deltaTime * speed);
this.transform.position=redplace.transform.position;
rb.constraints = RigidbodyConstraints2D.FreezePositionX;
print("Red hit");
 isred=true;
        }
    }
}
