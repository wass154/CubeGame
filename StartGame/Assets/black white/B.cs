using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B : MonoBehaviour
{
    public static bool isblue;
    public GameObject blueplace;
     public Rigidbody2D rb;
     public float speed=5f;
    // Start is called before the first frame update
    void Start()
    {
        isblue=false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("b")){
             //Vector2 newPos = Vector2.Lerp(this.transform.position, blueplace.transform.position, Time.deltaTime * speed);
this.transform.position=blueplace.transform.position;
rb.constraints = RigidbodyConstraints2D.FreezePositionX;
print("Blue hit");
isblue=true;
        }
    }
}
