using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallground : MonoBehaviour
{
    public Rigidbody2D rb;
    public float falldelay=1f;
    public float destroydelay=2f;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }


    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag("cube")) { // prefer to use compare tag
            
            StartCoroutine(fall()); //launch enumarator with startcoroutine 
        }

    }

    // Update is called once per frame
   private  IEnumerator fall(){ //enumartor =fall 
    yield return new WaitForSeconds(falldelay);//wait for amount of time time=falldelay
    rb.bodyType=RigidbodyType2D.Dynamic;// convert type body of ground from kinematic to dynamic
    Destroy(gameObject,destroydelay);
   }
}
