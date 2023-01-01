using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yellow : MonoBehaviour
{
    public float speed=2f;
   
    void Update(){
         RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.right); // hit 
   Vector2 right= transform.TransformDirection(-Vector2.right) * 3; //direction
        Debug.DrawRay(transform.position,right, Color.green);//green line
            if ( hit.collider.name=="player" && hit.distance<=3){ //condition with name of cube and distance between circle and cube
               print(hit.collider.name);
               print(hit.distance);
                 transform.Translate(Vector2.right*Time.deltaTime*speed); // replace with path
                 
             }
       
    }
}

