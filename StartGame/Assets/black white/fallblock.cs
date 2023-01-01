using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fallblock : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject cube;
     public GameObject block;

    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other){
if(other.gameObject.CompareTag("cube")){
   rb.isKinematic=false;
}
    }
    void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.CompareTag("cube")){
            Destroy(cube); 
             SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
       else if(other.gameObject.CompareTag("groundd")){
           Destroy(this);
      }
        
    }
    void OnTriggerExit2D(Collider2D other){
        if(other.gameObject.CompareTag("cube")){
            Destroy(this);
        }
       
      
    }
}
