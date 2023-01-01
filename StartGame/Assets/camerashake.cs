using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerashake : MonoBehaviour
{
    public float shakeduration=2f; //duration of shake
    public float magnitude=1f;//length of shake
    public Vector3 intialposition;
    // Start is called before the first frame update
    void Start()
    {
        intialposition=this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKeyDown(KeyCode.E)){
        StartCoroutine(shake());
    }
    }
    public IEnumerator shake(){
float x=Random.Range(-.5f,.5f);
float y=Random.Range(-.5f,.5f);
this.transform.position=Vector3.Lerp(this.transform.position,new Vector3(x,y,intialposition.z),.1f)*magnitude;
yield return null;
    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("b")){
            StartCoroutine(shake());
        }
    }
     void OnTriggerExit2D(Collider2D other){
        if(other.gameObject.CompareTag("b")){
           StopCoroutine(shake());
        }
    }
   
}
