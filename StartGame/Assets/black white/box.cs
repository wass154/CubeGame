using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class box : MonoBehaviour
{
    public float timer=3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("cube")){
          Invoke("death",timer);
        }
    }
    void death(){
          print("collid sucess");
          //reset level 
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
