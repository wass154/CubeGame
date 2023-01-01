using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blue : MonoBehaviour
{
       public GameObject cube;
    public Vector2 currentPos;
        public Vector2 targetPos;
      public float speed = 5f;
     public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       //current position of the game object
     currentPos = transform.position;
        //target position
       targetPos = cube.transform.position;
 
    }
    void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.CompareTag("cube")){
             Vector2 newPos = Vector2.Lerp(currentPos, targetPos, Time.deltaTime * speed);
             //update cube blue position to a new position
              transform.position = newPos;
              rb.constraints = RigidbodyConstraints2D.FreezePositionX;
        }
    }
    
}
