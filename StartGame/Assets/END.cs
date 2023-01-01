using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class END : MonoBehaviour
{
    public GameObject cube;
    public bool collide;
    public Canvas canvas;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        collide=false;
        anim=GetComponent<Animator>();
        canvas.enabled=false;
    }

    // Update is called once per frame
    void Update()
    {
        if(cubecolor.iscollide){
          Invoke("show",2);
           
        }
    }
    void show(){
        canvas.enabled=true;
        anim.SetTrigger("text");
    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("collide")){
            collide=true;
        }
    }
}
